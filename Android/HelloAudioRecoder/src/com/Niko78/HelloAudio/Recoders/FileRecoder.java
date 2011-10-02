package com.Niko78.HelloAudio.Recoders;

import java.io.BufferedOutputStream;
import java.io.DataOutputStream;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

import android.media.AudioFormat;
import android.media.AudioRecord;
import android.media.MediaRecorder;
import android.os.Environment;

public class FileRecoder extends BaseRecoder 
{

	private File fileName;
	
	public FileRecoder()
	{
		super();
		this.setFrequency(8000);
		this.setChannelConfiguration(AudioFormat.CHANNEL_CONFIGURATION_MONO);
		this.setPaused(false);
		
		fileName = new File(Environment.getExternalStorageDirectory().getAbsolutePath() + "/test.raw");		
	}
	
	public void run()
	{
		super.run();
	}
	
	@Override
	protected void CaptureSound() throws InterruptedException 
	{
		// Wait until we’re recording…
		synchronized (mutex) 	
		{
			while (!this.isRecording) 
			{
				mutex.wait();
			}
		}

		BufferedOutputStream bufferedStreamInstance = null;
		
		if (fileName.exists()) 
		{
			fileName.delete();
		}
		
		try 
		{
			fileName.createNewFile();
		} 
		catch (IOException e) 
		{
			throw new IllegalStateException("Cannot create file: " + fileName.toString());
		}
		
		try 
		{
			bufferedStreamInstance = new BufferedOutputStream(new FileOutputStream(this.fileName));
		} 
		catch (FileNotFoundException e) 
		{
			throw new IllegalStateException("Cannot Open File", e);
		}
		
		DataOutputStream dataOutputStreamInstance = new DataOutputStream(bufferedStreamInstance);		
		
		
		// We’re important…
		android.os.Process.setThreadPriority(android.os.Process.THREAD_PRIORITY_URGENT_AUDIO);
		
		// 	Allocate Recorder and Start Recording…
		int bufferRead = 0;
		int bufferSize = AudioRecord.getMinBufferSize(this.getFrequency(), this.getChannelConfiguration(), this.getAudioEncoding());
		
		bufferSize = 16000;
		
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
					mutex.wait(250);
					continue;
				}
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

			try 
			{
				for (int idxBuffer = 0; idxBuffer < bufferRead; ++idxBuffer) 
				{
					dataOutputStreamInstance.writeShort(tempBuffer[idxBuffer]);
				}
			} 
			catch (IOException e) 
			{
				throw new IllegalStateException("dataOutputStreamInstance.writeShort(curVal)");
			}			
		}
		
		// Close resources…
		recordInstance.stop();
		
		try 
		{
			bufferedStreamInstance.close();
		} 
		catch (IOException e) 
		{
			throw new IllegalStateException("“Cannot close buffered writer.");
		}
		
		
	}		
}
