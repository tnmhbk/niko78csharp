package com.Niko78.HelloAudio.Listeners;

import android.media.AudioFormat;
import android.media.AudioRecord;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Toast;

public class ShowMinBufferListener implements OnClickListener
{

	@Override
	public void onClick(View v)
	{
        int frequency = 8000;
        int channelConfiguration = AudioFormat.CHANNEL_CONFIGURATION_MONO;
        int audioEncoding = AudioFormat.ENCODING_PCM_16BIT;
        
        
        int bufferSize = AudioRecord.getMinBufferSize(frequency, channelConfiguration, audioEncoding);
        
        Toast toast =Toast.makeText(v.getContext().getApplicationContext(), "Min Buffer Size is " + Integer.toString(bufferSize), Toast.LENGTH_SHORT );
        toast.show();
		
	}

}
