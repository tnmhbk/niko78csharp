/**
 * @author niko78
 */
package com.niko78.IFSGenerator.Drawing;

import com.niko78.IFSGenerator.Common.Matrix3X3;
import com.niko78.IFSGenerator.Common.Point;

/**
 * Box class definition 
 */
public class Box {

    // Scale matrix
	private float[][] _scaleMatrix; 
	
	// Position Matrix
	private float[][] _positionMatrix;
	
	// combination of all matrix
	private float[][] _combinedMatrix; 
	
	public Box() {

		Selected = false;
		
		Vertexes = new Point[4];
		
		// Position initialization
		_positionMatrix = Matrix3X3.CreateIdentity();
		
		// Scale initialization
		_scaleMatrix = Matrix3X3.CreateIdentity();
		setWidth(0.5F);
		setHeight(0.5F);
		
		// Combined transformations
		_combinedMatrix = Matrix3X3.CreateIdentity();
		
		UpdateTransformations();
		
	}
	
	// Indicates if box is selected
	public boolean Selected;
	
	public Point[] Vertexes;
	
	/**
	 * @return X position of Box
	 */
	public float getPosX() {
		return _positionMatrix[0][2];
	}

	/**
	 * @param x the x position to set
	 */
	public void setPosX(float x) {
		_scaleMatrix[0][2] = x;
	} 
	
	/**
	 * @return Y position of Box
	 */
	public float getPosY() {
		return _positionMatrix[1][2];
	}

	/**
	 * @param Y the Y position to set
	 */
	public void setPosY(float y) {
		_scaleMatrix[1][2] = y;
	}	
	
	/**
	 * @return the Box height
	 */
	public float getHeight() {
		return _scaleMatrix[1][1];
	}

	/**
	 * @param height the Box height to set
	 */
	public void setHeight(float height) {
		_scaleMatrix[1][1] = height;
	} 

	/**
	 * @return the Box width
	 */
	public float getWidth() {
		return _scaleMatrix[0][0];
	}

	/**
	 * @param width the Box width to set
	 */
	public void setWidth(float width) {
		_scaleMatrix[0][0] = width;
	}
	
	public void UpdateTransformations()	{
		
		// [ x' , y' ] = TransfPos * TransfMirror * TransfRotacion * TransfRombo *  TransfEscala * [ x , y]

		// Calculate general transform matrix
		Matrix3X3.Multiply(_positionMatrix, _scaleMatrix, _combinedMatrix);

		// Calculate Vertexes
		Vertexes[0] = Matrix3X3.Transform(_combinedMatrix, -1.0F, -1.0F);
		Vertexes[1] = Matrix3X3.Transform(_combinedMatrix, -1.0F, +1.0F);
		Vertexes[2] = Matrix3X3.Transform(_combinedMatrix, +1.0F, +1.0F);
		Vertexes[3] = Matrix3X3.Transform(_combinedMatrix, +1.0F, -1.0F);
	}
}
