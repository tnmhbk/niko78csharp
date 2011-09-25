package com.Niko78.HelloAudio.Views;

import com.Niko78.HelloAudio.Common.Matrix3X3;
import com.Niko78.HelloAudio.Common.Point;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.util.AttributeSet;
import android.view.View;

public class WaveView extends View 
{
	private short[] _wave;
	
	private float _xMin = +0.0F;
	
	private float _xMax = +200.0F;
	
	private float _yMin = -32768.0F;
	
	private float _yMax = +32767.0F;
	
	private int _width;
	
	private int _heigth;	
	
	private float[][] _worldToScreen;
	
    Paint _paint = new Paint();
	

	public WaveView(Context context) 
	{
		super(context);
		_paint.setColor(Color.BLUE);
		_worldToScreen = Matrix3X3.CreateIdentity();
	}
	
    public WaveView(Context context, AttributeSet attrs)
    {
       super(context, attrs); 
       _paint.setColor(Color.BLUE);
       _worldToScreen = Matrix3X3.CreateIdentity();       
    }
    
    public void DrawWave(short[] wave)
    {
    	_wave = wave;
    	_xMax = wave.length;
    	RecelculateTransform();
    	invalidate();
    }
    
    @Override
    protected void onSizeChanged(int xNew, int yNew, int xOld, int yOld)
    {
    	_width = xNew;
    	_heigth = yNew;
    	
    	RecelculateTransform();
    }    
    
	public void RecelculateTransform()
	{
	     // Recalculate coordinates conversion
		_worldToScreen[0][0] =((float)_width)/(_xMax-_xMin);
		_worldToScreen[0][1] = 0.0F;
		_worldToScreen[0][2] =-(_worldToScreen[0][0]*_xMin);

		_worldToScreen[1][0] = 0.0F;
		_worldToScreen[1][1] = -((float)_heigth)/(_yMax-_yMin);
		_worldToScreen[1][2] = -(_worldToScreen[1][1]*_yMax);

		_worldToScreen[2][0] = 0.0F;
		_worldToScreen[2][1] = 0.0F;
	    _worldToScreen[2][2] = 1.0F;
	}
    

    @Override
    public void onDraw(Canvas canvas)
    {
    	super.onDraw(canvas);
         
        setBackgroundColor(Color.WHITE);         
         
        if (_wave == null)
        {
        	return;
        }
         
        for (int i= 0; i < _wave.length - 1 ; i++)
        {
        	Point pointA = Matrix3X3.Transform(_worldToScreen, i , _wave[i]);
            Point pointB = Matrix3X3.Transform(_worldToScreen, i+1 , _wave[i + 1]);
            canvas.drawLine(pointA.X, pointA.Y, pointB.X, pointB.Y, _paint);
        }
    }    

}
