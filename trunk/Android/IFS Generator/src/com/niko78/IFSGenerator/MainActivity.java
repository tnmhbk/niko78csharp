package com.niko78.IFSGenerator;

import com.niko78.IFSGenerator.Views.IFSView;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;

public class MainActivity extends Activity
implements OnClickListener
{

	/** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState) 
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);
        
        Button button = (Button)findViewById(R.id.btnApply);
        button.setOnClickListener(this);
    }
   
    // Implement the OnClickListener callback
    public void onClick(View v) 
    {
    	EditText edtPosX = (EditText)findViewById(R.id.edPosX);
    	EditText edtPosY = (EditText)findViewById(R.id.edPosY);
    	IFSView ifsView = (IFSView)findViewById(R.id.ifsView);

    	float posX = Float.parseFloat(edtPosX.getText().toString());
    	float posY = Float.parseFloat(edtPosY.getText().toString());
    	
    	ifsView.SetSelectedBoxValues(posX, posY);
    	
    	ifsView.invalidate();
    	
    }    
}