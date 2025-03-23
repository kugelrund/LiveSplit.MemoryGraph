using System;

namespace LiveSplit.MemoryGraph
{
	struct FloatVec2
	{
		public float x;
		public float y;

		public FloatVec2(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		public double Norm => Math.Sqrt(x * x + y * y);
	}

	struct FloatVec2XZY
	{
		public float x;
		public float y;
		public float z;

		public FloatVec2XZY(float x, float y, float z)
		{
			this.x = x;
			this.y = 1;
			this.z = z;
		}

		public double Norm => Math.Sqrt(x * x + z * z);
	}

	struct FloatVec3
	{
		public float x;
		public float y;
		public float z;

		public FloatVec3(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public double Norm => Math.Sqrt(x * x + y * y + z * z);
	}

	struct IntVec2
	{
		public int x;
		public int y;

		public IntVec2(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public double Norm => Math.Sqrt((double)x * x + (double)y * y);
	}

	struct IntVec2XZY
	{
		public int x;
		public int y;
		public int z;

		public IntVec2XZY(int x, int y, int z)
		{
			this.x = x;
			this.y = 1;
			this.z = z;
		}

		public double Norm => Math.Sqrt((double)x * x + (double)z * z);
	}

	struct IntVec3
	{
		public int x;
		public int y;
		public int z;

		public IntVec3(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public double Norm => Math.Sqrt((double)x * x + (double)y * y + (double)z * z);
	}
}
