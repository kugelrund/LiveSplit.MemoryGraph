//================================================================
// Majority of this class is based on class from Visual C# Kicks |
// Check out Visual C# Kicks - http://www.vcskicks.com/          |
//================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LiveSplit.MemoryGraph
{
    class GDI3D
    {
        static float PIOVER180 = (float)(Math.PI / 180);
        public class Vector3D
        {
            public float PosX { get; set; }
            public float PosY { get; set; }
            public float PosZ { get; set; }

            public Vector3D(float x, float y, float z)
            {
                PosX = x;
                PosY = y;
                PosZ = z;
            }

            public override string ToString()
            {
                return "Vec3D: (" + PosX.ToString() + ", " + PosY.ToString() + ", " + PosZ.ToString() + ")";
            }
        }

        internal class Camera3D
        {
            public Vector3D position = new Vector3D(0, 0, 0);
        }


        public class PivotWithValVector
        {
            public List<PointF> Corners2D;
            public Vector3D[] Corners3D;
            public Vector3D PivotOrigin;
            Graphics gBuffer;
            public Bitmap surface;


            public int width = 0;
            public int height = 0;
            public int depth = 0;

            float xRotation = 0.0f;
            float yRotation = 0.0f;
            float zRotation = 0.0f;


            #region Methods
            public float RotateX
            {
                get { return xRotation; }
                set
                {
                    RotateCubeX(value - xRotation);
                    xRotation = value;
                }
            }

            public float RotateY
            {
                get { return yRotation; }
                set
                {
                    RotateCubeY(value - yRotation);
                    yRotation = value;
                }
            }

            public float RotateZ
            {
                get { return zRotation; }
                set
                {
                    RotateCubeZ(value - zRotation);
                    zRotation = value;
                }
            }
            #endregion

            #region CubeRotation
            private void RotateCubeX(float deltaX)
            {
                for (int i = 0; i < Corners3D.Length; i++)
                {
                    Vector3D point0 = new Vector3D(0, 0, 0);
                    Corners3D[i] = Translate(Corners3D[i], PivotOrigin, point0); //Move corner to origin
                    Corners3D[i] = RotateX(Corners3D[i], deltaX);
                    Corners3D[i] = Translate(Corners3D[i], point0, PivotOrigin); //Move back
                }
            }

            private void RotateCubeY(float deltaY)
            {
                for (int i = 0; i < Corners3D.Length; i++)
                {
                    //Apply rotation
                    //------Rotate points
                    Vector3D point0 = new Vector3D(0, 0, 0);
                    Corners3D[i] = Translate(Corners3D[i], PivotOrigin, point0); //Move corner to origin
                    Corners3D[i] = RotateY(Corners3D[i], deltaY);
                    Corners3D[i] = Translate(Corners3D[i], point0, PivotOrigin); //Move back
                }
            }

            private void RotateCubeZ(float deltaZ)
            {
                for (int i = 0; i < Corners3D.Length; i++)
                {
                    //Apply rotation
                    //------Rotate points
                    Vector3D point0 = new Vector3D(0, 0, 0);
                    Corners3D[i] = Translate(Corners3D[i], PivotOrigin, point0); //Move corner to origin
                    Corners3D[i] = RotateZ(Corners3D[i], deltaZ);
                    Corners3D[i] = Translate(Corners3D[i], point0, PivotOrigin); //Move back
                }
            }
            #endregion

            #region Initializers
            public PivotWithValVector(int Width, int Height, int Depth, Bitmap bmpReference)
            {
                this.surface = bmpReference;
                gBuffer = Graphics.FromImage(surface);
                Corners2D = new List<PointF>();

                width = Width;
                height = Height;
                depth = Depth;
                PivotOrigin = new Vector3D(width / 2, height / 2, depth / 2);

                InitializeVecPivot();
            }
            
            private void InitializeVecPivot()
            {
                List<Vector3D> Corners3DL = new List<Vector3D>();
                //Center
                Corners3DL.Add(new Vector3D(0, 0, 0));

                //PivotVectors
                Corners3DL.Add(new Vector3D(width, 0, 0));
                Corners3DL.Add(new Vector3D(-width, 0, 0));

                Corners3DL.Add(new Vector3D(0, height, 0));
                Corners3DL.Add(new Vector3D(0, -height, 0));
                Corners3DL.Add(new Vector3D(0, 0, depth));

                //VelacityVectorShadows (indexes - 4, 5, 6, 7, 8,9)
                Corners3DL.Add(new Vector3D(width, -2, 0));
                Corners3DL.Add(new Vector3D(width, 2, 0));

                Corners3DL.Add(new Vector3D(-2, height, 0));
                Corners3DL.Add(new Vector3D(2, height, 0));

                Corners3DL.Add(new Vector3D(0, -2, depth));
                Corners3DL.Add(new Vector3D(0, 2, depth));

                //VelacityVector
                Corners3DL.Add(new Vector3D(width, height, depth));
                Corners3D = Corners3DL.ToArray();   //Cause Array should be slightly more efficient than List
            }
            #endregion

            #region DrawFunctions
            //Calculates the 2D points of each face
            private void Update2DPoints(Point drawOrigin)
            {
                Corners2D.Clear();

                //Update the 2D points of all the faces
                for (int i = 0; i < Corners3D.Length; i++)
                {
                    //Calculates the projected coordinates of the 3D points in a cube face

                    float zoom = (float)Screen.PrimaryScreen.Bounds.Width / 1.5f;
                    Point tmpOrigin = new Point(0, 0);

                    //Convert 3D Points to 2D
                    Corners2D.Add(Get2D(Corners3D[i], drawOrigin));
                }
            }


            private PointF Get2D(Vector3D vec, Point drawOrigin)
            {
                PointF point2D = Get2D(vec);
                return new PointF(point2D.X + drawOrigin.X, point2D.Y + drawOrigin.Y);
            }

            private PointF Get2D(Vector3D vec)
            {
                PointF returnPoint = new PointF();

                float zoom = (float)Screen.PrimaryScreen.Bounds.Width / 1.5f;
                Camera3D tempCam = new Camera3D();

                tempCam.position.PosX = PivotOrigin.PosX;
                tempCam.position.PosY = PivotOrigin.PosY;
                tempCam.position.PosZ = (PivotOrigin.PosX * zoom) / PivotOrigin.PosX;

                float zValue = -vec.PosZ - tempCam.position.PosZ;

                returnPoint.X = (tempCam.position.PosX - vec.PosX) / zValue * zoom;
                returnPoint.Y = (tempCam.position.PosX - vec.PosY) / zValue * zoom;

                return returnPoint;
            }

            public void updateXYZVectors(float VecX, float VecY, float VecZ)
            {
                //Sadly with this, this whole shit needs to be recalculated from beginning, so we have to reset rotation - would probably make more sense to just make it static function :(
                RotateX = 0;
                RotateY = 0;
                RotateZ = 0;

                //Center
                Corners3D[0] = new Vector3D(0, 0, 0);

                //PivotVectors
                Corners3D[1] = new Vector3D(width, 0, 0);
                Corners3D[2] = new Vector3D(-width, 0, 0);

                Corners3D[3] = new Vector3D(0, height, 0);
                Corners3D[4] = new Vector3D(0, -height, 0);

                Corners3D[5] = new Vector3D(0, 0, depth);


                //VelacityVectorShadows (indexes - 6, 7, 8, 9, 10,11)
                Corners3D[6] = new Vector3D(VecX  *width, 0, 0);
                Corners3D[7] = new Vector3D(VecX * width, VecY * height, 0);

                Corners3D[8] = new Vector3D(0, VecY * height, 0);
                Corners3D[9] = new Vector3D(VecX * width, VecY * height, 0);

                Corners3D[10] = new Vector3D(VecX * width, VecY*height, 0);
                Corners3D[11] = new Vector3D(VecX * width, VecY * height, VecZ * depth);

                //VelacityVector
                Corners3D[12] = new Vector3D(VecX*width, VecY*height, VecZ*depth);
            }

            public void DrawPivot(Point drawOrigin)
            {
                gBuffer.Clear(Color.Transparent);

                //Get the corresponding 2D
                Update2DPoints(drawOrigin);


                gBuffer.SmoothingMode = SmoothingMode.AntiAlias;

                gBuffer.DrawLine(Pens.Red, Corners2D[1], Corners2D[2]);   //x-Axis
                gBuffer.DrawLine(Pens.Green, Corners2D[3], Corners2D[4]);   //y-Axis
                gBuffer.DrawLine(Pens.Blue, Corners2D[0], Corners2D[5]);   //z-Axis

                gBuffer.DrawLine(Pens.White, Corners2D[6], Corners2D[7]);   //VecShadowX
                gBuffer.DrawLine(Pens.White, Corners2D[8], Corners2D[9]);   //VecShadowY
                gBuffer.DrawLine(Pens.White, Corners2D[10], Corners2D[11]);   //VecShadowZ

                gBuffer.DrawLine(Pens.Purple, Corners2D[0], Corners2D[12]);
            }
            #endregion
        }

        #region RotateSingleVectors
        public static Vector3D RotateX(Vector3D point3D, float degrees)
        {
            //[ a  b  c ] [ x ]   [ x*a + y*b + z*c ]
            //[ d  e  f ] [ y ] = [ x*d + y*e + z*f ]
            //[ g  h  i ] [ z ]   [ x*g + y*h + z*i ]

            //[ 1    0        0   ]
            //[ 0   cos(x)  sin(x)]
            //[ 0   -sin(x) cos(x)]

            double cDegrees = degrees * PIOVER180;
            double cosDegrees = Math.Cos(cDegrees);
            double sinDegrees = Math.Sin(cDegrees);

            double y = (point3D.PosY * cosDegrees) + (point3D.PosZ * sinDegrees);
            double z = (point3D.PosY * -sinDegrees) + (point3D.PosZ * cosDegrees);

            return new Vector3D(point3D.PosX, (float)y, (float)z);
        }

        public static Vector3D RotateY(Vector3D point3D, float degrees)
        {
            //[ cos(x)   0    sin(x)]
            //[   0      1      0   ]
            //[-sin(x)   0    cos(x)]

            double cDegrees = degrees * PIOVER180;
            double cosDegrees = Math.Cos(cDegrees);
            double sinDegrees = Math.Sin(cDegrees);

            double x = (point3D.PosX * cosDegrees) + (point3D.PosZ * sinDegrees);
            double z = (point3D.PosX * -sinDegrees) + (point3D.PosZ * cosDegrees);

            return new Vector3D((float)x, point3D.PosY, (float)z);
        }

        public static Vector3D RotateZ(Vector3D point3D, float degrees)
        {
            //[ cos(x)  sin(x) 0]
            //[ -sin(x) cos(x) 0]
            //[    0     0     1]

            double cDegrees = degrees * PIOVER180;
            double cosDegrees = Math.Cos(cDegrees);
            double sinDegrees = Math.Sin(cDegrees);

            double x = (point3D.PosX * cosDegrees) + (point3D.PosY * sinDegrees);
            double y = (point3D.PosX * -sinDegrees) + (point3D.PosY * cosDegrees);

            return new Vector3D((float)x, (float)y, point3D.PosZ);
        }
        #endregion

        #region RotateVectorArray
        public static Vector3D[] RotateX(Vector3D[] points3D, float degrees)
        {
            for (int i = 0; i < points3D.Length; i++)
            {
                points3D[i] = RotateX((Vector3D)points3D[i], degrees);
            }
            return points3D;
        }

        public static Vector3D[] RotateY(Vector3D[] points3D, float degrees)
        {
            for (int i = 0; i < points3D.Length; i++)
            {
                points3D[i] = RotateY((Vector3D)points3D[i], degrees);
            }
            return points3D;
        }

        public static Vector3D[] RotateZ(Vector3D[] points3D, float degrees)
        {
            for (int i = 0; i < points3D.Length; i++)
            {
                points3D[i] = RotateZ((Vector3D)points3D[i], degrees);
            }
            return points3D;
        }
        #endregion

        #region VectorTranslate
        public static Vector3D[] Translate(Vector3D[] points3D, Vector3D oldOrigin, Vector3D newOrigin)
        {
            for (int i = 0; i < points3D.Length; i++)
            {
                points3D[i] = Translate(points3D[i], oldOrigin, newOrigin);
            }
            return points3D;
        }


        public static Vector3D Translate(Vector3D points3D, Vector3D oldOrigin, Vector3D newOrigin)
        {
            Vector3D difference = new Vector3D(newOrigin.PosX - oldOrigin.PosX, newOrigin.PosY - oldOrigin.PosY, newOrigin.PosZ - oldOrigin.PosZ);
            points3D.PosX += difference.PosX;
            points3D.PosY += difference.PosY;
            points3D.PosZ += difference.PosZ;
            return points3D;
        }
        #endregion

        public GDI3D()
        {

        }
    }
}
