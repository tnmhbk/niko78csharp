package com.Niko78.HelloAudio.Listeners;

import android.view.View;
import android.view.View.OnClickListener;

import com.Niko78.HelloAudio.Recorder;

public class StopRecoderListener implements OnClickListener
{
	Recorder _recoder;
		
	public StopRecoderListener(Recorder recoder)
	{
		_recoder = recoder;
	}

	@Override
	public void onClick(View v) 
	{
		_recoder.setRecording(false);
	}
}	
