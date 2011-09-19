/**
 * 
 */
package com.niko78.IFSGenerator.Drawing;

import java.util.ArrayList;
import java.util.List;

import com.niko78.IFSGenerator.Common.Matrix3X3;
import com.niko78.IFSGenerator.Common.Point;
import com.niko78.IFSGenerator.Listeners.BoxParameter;

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
	
	/**
	 * @param canvas 
	 */
	public void Draw(Canvas canvas)
	{
		DrawBox(canvas, _boxes.get(0));
	}
	
	/** Set selected Box Parameter
	 * @param boxParameter The Box parameter to Set
	 * @param value The box parameter Value
	 */
	public void setSelectedBoxParameter(BoxParameter boxParameter, float value)
	{
		Box box = GetSelectedBox();
		
		if (box == null)
		{
			return;
		}
		
		switch (boxParameter)
		{
		case PosX:
			box.setPosX(value);
			break;
		case PosY:
			box.setPosY(value);
			break;
		case Width:
			box.setWidth(value);
			break;			
		case Height:
			box.setHeight(value);
			break;			
		default:
			break;
		}

		box.UpdateTransformations();
	}
	
	public Box GetSelectedBox()
	{
		return _boxes.get(0);
	}
	
	private void DrawBox(Canvas canvas, Box box)
	{
		// Calculate point screen points
		Point pointA = Matrix3X3.Transform(_worldToScreen, box.Vertexes[0].X, box.Vertexes[0].Y);
		Point pointB = Matrix3X3.Transform(_worldToScreen, box.Vertexes[1].X, box.Vertexes[1].Y);
		Point pointC = Matrix3X3.Transform(_worldToScreen, box.Vertexes[2].X, box.Vertexes[2].Y);
		Point pointD = Matrix3X3.Transform(_worldToScreen, box.Vertexes[3].X, box.Vertexes[3].Y);		
		
		// Draw Box lines
        canvas.drawLine(pointA.X, pointA.Y, pointB.X, pointB.Y, paint);
        canvas.drawLine(pointB.X, pointB.Y, pointC.X, pointC.Y, paint);
        canvas.drawLine(pointC.X, pointC.Y, pointD.X, pointD.Y, paint);
        canvas.drawLine(pointD.X, pointD.Y, pointA.X, pointA.Y, paint);
	}
}
