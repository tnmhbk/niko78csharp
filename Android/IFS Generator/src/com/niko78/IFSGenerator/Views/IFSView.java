/**
 * 
 */
package com.niko78.IFSGenerator.Views;

import com.niko78.IFSGenerator.R;
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
        
    	_boxDrawer = new BoxDrawer(); 
    }
    
    public IFSView(Context context, AttributeSet attrs)
    {
       super(context, attrs); 

       _boxDrawer = new BoxDrawer();
    }    
    
    @Override
    protected void onSizeChanged(int xNew, int yNew, int xOld, int yOld)
    {
    	_boxDrawer.SizeChanged(xNew, yNew);
    }
    
    @Override
    public void onDraw(Canvas canvas)
    {
         super.onDraw(canvas);
         
         setBackgroundColor(Color.WHITE);         
         
         _boxDrawer.Draw(canvas);
   }
    
    public void SetSelectedBoxValues(float posX, float posY) 
    {
    	_boxDrawer.SetSelectedBoxValues(posX, posY);
    };
    
}