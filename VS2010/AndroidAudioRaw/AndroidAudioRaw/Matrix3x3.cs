using System.Drawing;

namespace AndroidAudioRaw
{
    public class Matrix3X3
    {
        public static float[,] CreateIdentity()
        {
            float[,] result = new float[3,3];

            result[0, 0] = 1;
            result[0, 1] = 0;
            result[0, 2] = 0;
            result[1, 0] = 0;
            result[1, 1] = 1;
            result[1, 2] = 0;
            result[2, 0] = 0;
            result[2, 1] = 0;
            result[2, 2] = 1;

            return result;
        }

        public static float[,] Multiply(float[,] A, float[,] B)
        {
            float[,] result = new float[3,3];

            Multiply(A, B, result);

            return result;
        }

        public static void Multiply(float[, ] a, float[, ] b, float[, ] result)
        {
            result[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0] + a[0, 2] * b[2, 0];
            result[0, 1] = a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1] + a[0, 2] * b[2, 1];
            result[0, 2] = a[0, 0] * b[0, 2] + a[0, 1] * b[1, 2] + a[0, 2] * b[2, 2];

            result[1, 0] = a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0] + a[1, 2] * b[2, 0];
            result[1, 1] = a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1] + a[1, 2] * b[2, 1];
            result[1, 2] = a[1, 0] * b[0, 2] + a[1, 1] * b[1, 2] + a[1, 2] * b[2, 2];

            result[2, 0] = a[2, 0] * b[0, 0] + a[2, 1] * b[1, 0] + a[2, 2] * b[2, 0];
            result[2, 1] = a[2, 0] * b[0, 1] + a[2, 1] * b[1, 1] + a[2, 2] * b[2, 1];
            result[2, 2] = a[2, 0] * b[0, 2] + a[2, 1] * b[1, 2] + a[2, 2] * b[2, 2];
        }

        public static PointF Transform(float[, ] matrix, float X, float Y)
        {
            PointF result = new PointF();
            result.X = (X * matrix[0, 0]) + (Y * matrix[0, 1]) + (matrix[0, 2]);
            result.Y = (X * matrix[1, 0]) + (Y * matrix[1, 1]) + (matrix[1, 2]);
            return result;
        }
    }

}
