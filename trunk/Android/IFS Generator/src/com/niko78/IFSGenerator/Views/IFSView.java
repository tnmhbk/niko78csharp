/**
 * 
 */
package com.niko78.IFSGenerator.Views;

import com.niko78.IFSGenerator.Drawing.BoxDrawer;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.util.AttributeSet;
import android.view.View;


/**
 * @author Nicolas
 *
 */
public class IFSView extends View
{
	private BoxDrawer _boxDrawer;
	
    public IFSView(Context context)
    {
    	super(context);
    }
    
    public IFSView(Context context, AttributeSet attrs)
    {
       super(context, attrs); 
    }
    
    ///Set box drawer instance
    public void setBoxDrawer(BoxDrawer boxDrawer)
    {
    	_boxDrawer = boxDrawer;
    }
    
    @Override
    protected void onSizeChanged(int xNew, int yNew, int xOld, int yOld)
    {
        if (_boxDrawer != null)
        {
    	   _boxDrawer.SizeChanged(xNew, yNew);
        }
    }
    
    @Override
    public void onDraw(Canvas canvas)
    {
         super.onDraw(canvas);
         
         setBackgroundColor(Color.WHITE);         
         
         if (_boxDrawer != null)
         {
            _boxDrawer.Draw(canvas);
         }
   }

}