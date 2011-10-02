package com.Niko78.HelloAudio;

import com.Niko78.HelloAudio.Listeners.ShowMinBufferListener;
import com.Niko78.HelloAudio.Listeners.StartRecodingListener;
import com.Niko78.HelloAudio.Listeners.StopRecoderListener;
import com.Niko78.HelloAudio.Recoders.BaseRecoder;
import com.Niko78.HelloAudio.Recoders.FileRecoder;
import com.Niko78.HelloAudio.Views.WaveView;

import android.app.Activity;
import android.os.Bundle;
import android.widget.Button;

public class MainActivity extends Activity 
{
	BaseRecoder _recoder;
	
    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);

        // Recorder class
        //_recoder = new Recorder((WaveView)findViewById(R.id.waveView));
        _recoder = new FileRecoder();
        
        SetListeners();
    }
    
    
    private void SetListeners()
    {
    	Button button = (Button)findViewById(R.id.btnMinBuffer);
    	button.setOnClickListener(new ShowMinBufferListener());
    	
    	Button btnStart = (Button)findViewById(R.id.btnStart);
    	btnStart.setOnClickListener(new StartRecodingListener(_recoder));
    	
       	Button btnStop = (Button)findViewById(R.id.btnStop);
       	btnStop.setOnClickListener(new StopRecoderListener(_recoder));    	
    }
    
}