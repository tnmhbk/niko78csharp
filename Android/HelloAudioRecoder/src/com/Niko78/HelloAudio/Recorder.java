package com.Niko78.HelloAudio;

import android.media.AudioFormat;
import android.media.AudioRecord;
import android.media.MediaRecorder;
import android.widget.TextView;

public class Recorder implements Runnable
{
	private int frequency;
	private int channelConfiguration;
	private volatile boolean isPaused;
	private volatile boolean isRecording;
	private final Object mutex = new Object();
	private TextView _associatedView;	

	// Changing the sample resolution changes sample type. byte vs. short.
	private static final int audioEncoding = AudioFormat.ENCODING_PCM_16BIT;

/**
*
*/
	public Recorder(TextView associatedView) 
	{
		super();
		this.setFrequency(8000);
		this.setChannelConfiguration(AudioFormat.CHANNEL_CONFIGURATION_MONO);
		this.setPaused(false);
		_associatedView = associatedView;		
	}

	public void run() 
	{
		// Wait until we’re recording…
		synchronized (mutex) 	
		{
			while (!this.isRecording) 
			{
				try 
				{
					mutex.wait();
				} 
				catch (InterruptedException e) 
				{
					throw new IllegalStateException("Wait() interrupted!", e);
				}
			}
		}

		// We’re important…
		android.os.Process.setThreadPriority(android.os.Process.THREAD_PRIORITY_URGENT_AUDIO);

		// 	Allocate Recorder and Start Recording…
		int bufferRead = 0;
		int bufferSize = AudioRecord.getMinBufferSize(this.getFrequency(), this.getChannelConfiguration(), this.getAudioEncoding());
		
		bufferSize = 8000;
		
		AudioRecord recordInstance = new AudioRecord(MediaRecorder.AudioSource.MIC, this.getFrequency(), this.getChannelConfiguration(), this.getAudioEncoding(), bufferSize);

		short[] tempBuffer = new short[bufferSize];
		
		// Start Recording
		recordInstance.startRecording();
		
		while (this.isRecording) 
		{
			// 	Are we paused?
			synchronized (mutex) 
			{
				if (this.isPaused) 
				{
					try 
					{
						mutex.wait(250);
					} 
					catch (InterruptedException e) 
					{
							
					}
					
					continue;
				}
			}

			try 
			{
				Thread.sleep(500);
			}
			catch (InterruptedException e) 
			{
				
			}
			
			// Read Audio buffer 
			bufferRead = recordInstance.read(tempBuffer, 0, bufferSize);
			
			if (bufferRead == AudioRecord.ERROR_INVALID_OPERATION) 
			{
				throw new IllegalStateException("read() returned AudioRecord.ERROR_INVALID_OPERATION");
			} 
			else if (bufferRead == AudioRecord.ERROR_BAD_VALUE) 
			{
				throw new IllegalStateException("read() returned AudioRecord.ERROR_BAD_VALUE");
			}
			else if (bufferRead == AudioRecord.ERROR_INVALID_OPERATION) 
			{
				throw new IllegalStateException("“read() returned AudioRecord.ERROR_INVALID_OPERATION");
			}

			float average = 0.0F;
			
			for (int idxBuffer = 0; idxBuffer < bufferRead; ++idxBuffer) 
			{
				average = average + tempBuffer[idxBuffer];
			}
			
			average = average / bufferRead;
			
			

		}

		// Close resources…
		recordInstance.stop();
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

}