package com.Niko78.HelloAudio.Listeners;

import com.Niko78.HelloAudio.Recoders.BaseRecoder;

import android.view.View;
import android.view.View.OnClickListener;

public class StartRecodingListener implements OnClickListener 
{
	BaseRecoder _recoder;
	
	public StartRecodingListener(BaseRecoder recoder)
	{
		_recoder = recoder;
	}

	@Override
	public void onClick(View v) 
	{
        _recoder.setRecording(true);
        Thread th = new Thread(_recoder);
        th.start();
		
	}

}
