package com.Niko78.HelloAudio.Runners;

import com.Niko78.HelloAudio.Views.WaveView;

public class WaveUpdater implements Runnable
{
	WaveView _waveView;
	short[] _wave;
	
	public WaveUpdater(WaveView waveView, short[] wave)
	{
		_waveView = waveView;
		
		if (wave.length < 200)
		{
			_wave = wave.clone();
		}
		else
		{
			int step = wave.length / 200;
			
			_wave = new short[200];
			
			for (int i = 0; i < 200; i++)
			{
				float sum = 0;
				
				for (int j = 0; j < step; j++)
				{
					sum = sum + wave[ (i * step) + j];
				}
				
				_wave[i] = (short) (sum / (float)step);
			}
		}
	}

	@Override
	public void run() 
	{
		_waveView.DrawWave(_wave);
	}

}
