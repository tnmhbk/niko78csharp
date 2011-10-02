package com.Niko78.HelloAudio.Recoders;

import android.media.AudioFormat;

public abstract class BaseRecoder implements Runnable 
{
	protected int frequency;
	protected int channelConfiguration;
	protected volatile boolean isPaused;
	protected volatile boolean isRecording;
	protected final Object mutex = new Object();
	
	// Changing the sample resolution changes sample type. byte vs. short.
	protected static final int audioEncoding = AudioFormat.ENCODING_PCM_16BIT;
	
	public void run()
	{
		try 
		{
			CaptureSound();
		}
		catch (InterruptedException e) 
		{
			e.printStackTrace();
		}
	}
	
	public void setRecording(boolean isRecording) 
	{
		synchronized (mutex) 
		{
			this.isRecording = isRecording;
			if (this.isRecording) 
			{
				mutex.notify();
			}
		}
	}

	public boolean isRecording() 
	{
		synchronized (mutex) 
		{
			return isRecording;
		}
	}

	public void setFrequency(int frequency) 
	{
		this.frequency = frequency;
	}

	public int getFrequency() 
	{
		return frequency;
	}

	public void setChannelConfiguration(int channelConfiguration) 
	{
		this.channelConfiguration = channelConfiguration;
	}

	public int getChannelConfiguration() 
	{
		return channelConfiguration;
	}

	public int getAudioEncoding() 
	{
		return audioEncoding;
	}

	public void setPaused(boolean isPaused) 
	{
		synchronized (mutex) 
		{
			this.isPaused = isPaused;
		}
	}

	public boolean isPaused() 
	{
		synchronized (mutex) 
		{
			return isPaused;
		}
	}
	
	protected abstract void CaptureSound() throws InterruptedException;	
	
}
