/**
 * 
 */
package com.niko78.IFSGenerator.Drawing;

import java.util.ArrayList;
import java.util.List;

import com.niko78.IFSGenerator.Common.Matrix3X3;
import com.niko78.IFSGenerator.Common.Point;

import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;

/**
 * @author niko78
 *
 */
public class BoxDrawer 
{
	// Boxes collection
	private List<Box> _boxes;
	
	private float _xMin = -1.0F;
	
	private float _xMax = +1.0F;
	
	private float _yMin = -1.0F;
	
	private float _yMax = +1.0F;
	
	private float[][] _worldToScreen;
	
    Paint paint = new Paint();	
	
	public BoxDrawer()
	{
		_worldToScreen = Matrix3X3.CreateIdentity();
		
		_boxes = new ArrayList<Box>();
		
        paint.setColor(Color.BLUE);
        
        Box box = new Box();
        AddBox(box);
	}
	
	public void AddBox(Box box)
	{
		_boxes.add(box);
	}
	
	public void SizeChanged(int xNew, int yNew)
	{
		// Recalculate coordinates rages
		if (xNew > yNew)
		{
			_yMin = -1.0F;
			_yMax = +1.0F;
			_xMin = -1.0F * (float)xNew / (float)yNew;
			_xMax = +1.0F * (float)xNew / (float)yNew;
		}
		
	     // Recalculate coordinates conversion
		_worldToScreen[0][0] =((float)xNew)/(_xMax-_xMin);
		_worldToScreen[0][1] = 0.0F;
		_worldToScreen[0][2] =-(_worldToScreen[0][0]*_xMin);

		_worldToScreen[1][0] = 0.0F;
		_worldToScreen[1][1] = -((float)yNew)/(_yMax-_yMin);
		_worldToScreen[1][2] = -(_worldToScreen[1][1]*_yMax);

		_worldToScreen[2][0] = 0.0F;
		_worldToScreen[2][1] = 0.0F;
	    _worldToScreen[2][2] = 1.0F;
	}
	
	public void Draw(Canvas canvas)
	{
		DrawBox(canvas, _boxes.get(0));
	}
	
	public void SetSelectedBoxValues(float posX, float posY)
	{
		_boxes.get(0).setPosX(posX);
		_boxes.get(0).setPosY(posY);
		
		_boxes.get(0).UpdateTransformations();
	}
	
	private void DrawBox(Canvas canvas, Box box)
	{
		// Calculate point screen points
		Point pointA = Matrix3X3.Transform(_worldToScreen, box.Vertexes[0].X, box.Vertexes[0].Y);
		Point pointB = Matrix3X3.Transform(_worldToScreen, box.Vertexes[1].X, box.Vertexes[1].Y);
		Point pointC = Matrix3X3.Transform(_worldToScreen, box.Vertexes[2].X, box.Vertexes[2].Y);
		Point pointD = Matrix3X3.Transform(_worldToScreen, box.Vertexes[3].X, box.Vertexes[3].Y);		
		
        canvas.drawLine(pointA.X, pointA.Y, pointB.X, pointB.Y, paint);
        canvas.drawLine(pointB.X, pointB.Y, pointC.X, pointC.Y, paint);
        canvas.drawLine(pointC.X, pointC.Y, pointD.X, pointD.Y, paint);
        canvas.drawLine(pointD.X, pointD.Y, pointA.X, pointA.Y, paint);
	}
}
