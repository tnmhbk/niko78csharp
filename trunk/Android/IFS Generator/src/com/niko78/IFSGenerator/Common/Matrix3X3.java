package com.niko78.IFSGenerator.Common;

public class Matrix3X3 {

	public static float[][] CreateIdentity()
	{
		
		float[][] result = new float[3][3];
		
		result[0][0] = 1;
		result[0][1] = 0;
		result[0][2] = 0;		
		result[1][0] = 0;
		result[1][1] = 1;
		result[1][2] = 0;
		result[2][0] = 0;
		result[2][1] = 0;
		result[2][2] = 1;

		return result;
	}
	
	public static float[][] Multiply(float[][] A,float[][] B)
	{
		float[][] result = new float[3][3];
		
		Multiply(A, B, result);
				
	    return result;
	}
	
	public static void Multiply(float[][] A,float[][] B,float[][] result)
	{
	    result[0][0] = A[0][0] * B[0][0] + A[0][1] * B[1][0] + A[0][2] * B[2][0];
	    result[0][1] = A[0][0] * B[0][1] + A[0][1] * B[1][1] + A[0][2] * B[2][1];
	    result[0][2] = A[0][0] * B[0][2] + A[0][1] * B[1][2] + A[0][2] * B[2][2];

	    result[1][0] = A[1][0] * B[0][0] + A[1][1] * B[1][0] + A[1][2] * B[2][0];
	    result[1][1] = A[1][0] * B[0][1] + A[1][1] * B[1][1] + A[1][2] * B[2][1];
	    result[1][2] = A[1][0] * B[0][2] + A[1][1] * B[1][2] + A[1][2] * B[2][2];

	    result[2][0] = A[2][0] * B[0][0] + A[2][1] * B[1][0] + A[2][2] * B[2][0];
	    result[2][1] = A[2][0] * B[0][1] + A[2][1] * B[1][1] + A[2][2] * B[2][1];
	    result[2][2] = A[2][0] * B[0][2] + A[2][1] * B[1][2] + A[2][2] * B[2][2];
	}

	public static Point Transform(float[][] matrix,float X,float Y)
	{
		Point result = new Point();
		result.X = (X * matrix[0][0]) + (Y * matrix[0][1]) + (matrix[0][2]);
		result.Y = (X * matrix[1][0]) + (Y * matrix[1][1]) + (matrix[1][2]);
        return result;
	}	
}
