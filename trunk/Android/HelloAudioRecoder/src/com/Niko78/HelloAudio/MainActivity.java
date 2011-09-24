package com.Niko78.HelloAudio;

import com.Niko78.HelloAudio.Listeners.ShowMinBufferListener;

import android.app.Activity;
import android.media.AudioFormat;
import android.media.AudioRecord;
import android.os.Bundle;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends Activity 
{
	
    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);
        
        SetListeners();
        
        
        Recorder helloTherad = new Recorder((TextView)findViewById(R.id.texTitle));
        helloTherad.setRecording(true);
        
        Thread th = new Thread(helloTherad);
        th.start();
        
    }
    
    
    private void SetListeners()
    {
    	Button button = (Button)findViewById(R.id.btnMinBuffer);
    	button.setOnClickListener( new ShowMinBufferListener());
    }
    
    
    
}