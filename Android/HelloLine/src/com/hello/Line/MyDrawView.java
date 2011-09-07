package com.hello.Line;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.util.AttributeSet;
import android.view.View;

public class MyDrawView extends View {
    Paint paint = new Paint();

    public MyDrawView(Context context) {
    	super(context);
        
        setBackgroundColor(Color.WHITE);        
        
        paint.setColor(Color.BLUE);
    }
    
    public MyDrawView(Context context, AttributeSet attrs) {
       super(context, attrs); 

       setBackgroundColor(Color.WHITE);        
       
       paint.setColor(Color.BLUE);       
      }    
    
    @Override
    public void onDraw(Canvas canvas) {
         super.onDraw(canvas);
            canvas.drawLine(10, 20, 30, 40, paint);
            canvas.drawLine(20, 10, 50, 20, paint);

    }
}