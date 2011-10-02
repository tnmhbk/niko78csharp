package com.Niko78.HelloAudio.Listeners;

import android.view.View;
import android.view.View.OnClickListener;

import com.Niko78.HelloAudio.Recoders.BaseRecoder;

public class StopRecoderListener implements OnClickListener
{
	BaseRecoder _recoder;
		
	public StopRecoderListener(BaseRecoder recoder)
	{
		_recoder = recoder;
	}

	@Override
	public void onClick(View v) 
	{
		_recoder.setRecording(false);
	}
}	
