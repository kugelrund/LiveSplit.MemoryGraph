using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LiveSplit.MemoryGraph
{
    class SonicHandling
    {
        public sonicHandlingSizes[] idle;
        public sonicHandlingSizes[] idle_foot;
        public sonicHandlingSizes[] walking;
        public sonicHandlingSizes[] running;
        public sonicHandlingSizes[] idle_frustrated;
        public sonicHandlingSizes[] sonic_sprint;

        private enum sonicStatesIDs : int
        {
            idle,
            idle_foot,
            idle_frustrated,
            walking,
            running,
            sprinting
        };

        public int sonic_state;
        private int previous_sonic_state;
        public int sonic_repetition;
        public int sonic_frame;

        public SonicHandling()
        {
            idle = new sonicHandlingSizes[11];
            for (int i=0; i<idle.Length; i++)
            {
                idle[i] = new sonicHandlingSizes(i * 36, 0, 36, 46);
            }

            idle_foot = new sonicHandlingSizes[]            //foot animation (animated at draw/3)
            {
                new sonicHandlingSizes(572, 0, 36, 46),
                new sonicHandlingSizes(608, 0, 36, 46),
                new sonicHandlingSizes(644, 0, 36, 46),
                new sonicHandlingSizes(644, 0, 36, 46),
                new sonicHandlingSizes(608, 0, 36, 46),
                new sonicHandlingSizes(644, 0, 36, 46),
                new sonicHandlingSizes(608, 0, 36, 46),
                new sonicHandlingSizes(644, 0, 36, 46),
                new sonicHandlingSizes(644, 0, 36, 46),
                new sonicHandlingSizes(608, 0, 36, 46),
                new sonicHandlingSizes(572, 0, 36, 46),
                new sonicHandlingSizes(572, 0, 36, 46),
            };

            walking = new sonicHandlingSizes[16];
            for (int i = 0; i < walking.Length; i++)
            {
                walking[i] = new sonicHandlingSizes(i/2 * 36 + 680, 0, 36, 46);
            }

            running = new sonicHandlingSizes[8];
            for (int i = 0; i < running.Length; i++)
            {
                running[i] = new sonicHandlingSizes(i * 36 +680, 0, 36, 46);
            }

            idle_frustrated = new sonicHandlingSizes[80];
            for (int i=0; i<40; i++)
            {
                idle_frustrated[i] = new sonicHandlingSizes(i * 36, 47, 36, 46);
            }
            for (int i = 0; i < 40; i++)
            {
                idle_frustrated[i+40] = new sonicHandlingSizes(i * 36, 94, 36, 46);
            }

            sonic_sprint = new sonicHandlingSizes[4];
            for(int i=0; i<sonic_sprint.Length; i++)
            {
                sonic_sprint[i] = new sonicHandlingSizes(i * 36 + 1004, 0, 36, 46);
            }

            sonic_state = 0;
            sonic_repetition = 0;
            sonic_frame = 0;
        }

        public Bitmap getBitmap(float relativeValue)
        {
            sonic_frame++;
            if(relativeValue <0.01)
            {
                if (sonic_repetition == 0 && sonic_state!= (int)sonicStatesIDs.idle_foot && sonic_state!=(int)sonicStatesIDs.idle_frustrated)
                    sonic_state = (int)sonicStatesIDs.idle;
                if(sonic_repetition==6*idle.Length)
                    sonic_state = (int)sonicStatesIDs.idle_foot;
                if (sonic_repetition == 6 * idle.Length + 2 * idle_foot.Length)
                    sonic_state = (int)sonicStatesIDs.idle_frustrated;
                if (sonic_repetition == 6 * idle.Length + 2 * idle_foot.Length + idle_frustrated.Length)
                {
                    sonic_state = 0;
                    sonic_repetition = 0;
                }
                    

                sonic_repetition++;
            }
            else if (relativeValue > 0 && relativeValue < 0.3f)
            {
                sonic_state = (int)sonicStatesIDs.walking;
            }
            else if(relativeValue>0.3f && relativeValue < 0.75f)
            {
                sonic_state = (int)sonicStatesIDs.running;
            }
            else
            {
                sonic_state = (int)sonicStatesIDs.sprinting;
            }

            if(previous_sonic_state==(int)sonicStatesIDs.walking && sonic_state==(int)sonicStatesIDs.running)       //this and next one for smoothing out transitions between half speed and full speed running loop
            {
                sonic_frame = sonic_frame / 2;
            }
            else if(previous_sonic_state==(int)sonicStatesIDs.running && sonic_state==(int)sonicStatesIDs.walking)
            {
                sonic_frame = sonic_frame * 2;
            }
            else if (previous_sonic_state!= sonic_state)            //for reseting to frame 0 of each loop
            {
                sonic_frame = 0;
            }
            previous_sonic_state = sonic_state;


            //Get a frame from sprite sheet
            if(sonic_state==(int)sonicStatesIDs.idle)
            {
                if (sonic_frame >= idle.Length)
                    sonic_frame = 0;
                return cropBitmap(Properties.Resources.sonic_spirtes, getArray(idle, sonic_frame));
            }
            else if (sonic_state == (int)sonicStatesIDs.idle_foot)
            {
                if (sonic_frame >= idle_foot.Length)
                    sonic_frame = 0;
                return cropBitmap(Properties.Resources.sonic_spirtes, getArray(idle_foot, sonic_frame));
            }
            else if (sonic_state == (int)sonicStatesIDs.idle_frustrated)
            {
                if (sonic_frame >= idle_frustrated.Length)
                    sonic_frame = 0;
                return cropBitmap(Properties.Resources.sonic_spirtes, getArray(idle_frustrated, sonic_frame));
            }
            else if (sonic_state == (int)sonicStatesIDs.walking)
            {
                if (sonic_frame >= walking.Length)
                    sonic_frame = 0;
                sonic_repetition = 0;
                return cropBitmap(Properties.Resources.sonic_spirtes, getArray(walking, sonic_frame));
            }
            else if (sonic_state == (int)sonicStatesIDs.running)
            {
                if (sonic_frame >= running.Length)
                    sonic_frame = 0;
                sonic_repetition = 0;
                return cropBitmap(Properties.Resources.sonic_spirtes, getArray(running, sonic_frame));
            }
            else
            {
                if (sonic_frame >= sonic_sprint.Length)
                    sonic_frame = 0;
                sonic_repetition = 0;
                return cropBitmap(Properties.Resources.sonic_spirtes, getArray(sonic_sprint, sonic_frame));
            }
        }

        private int[] getArray(sonicHandlingSizes[] source, int frame)
        {
            return new int[] { source[frame].left, source[frame].top, source[frame].width, source[frame].height };
        }

        private static Bitmap cropBitmap(Bitmap bitmap, int[] array)
        {
            return bitmap.Clone(new Rectangle(array[0], array[1], array[2], array[3]), bitmap.PixelFormat);
        }
    }

    class sonicHandlingSizes
    {
        public int top;
        public int left;
        public int width;
        public int height;

        public sonicHandlingSizes(int x, int y, int w, int h)
        {
            left = x;
            top = y;
            width = w;
            height = h;
        }
    }
}
