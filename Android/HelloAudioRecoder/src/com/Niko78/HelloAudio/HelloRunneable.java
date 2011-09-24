package com.Niko78.HelloAudio;

import android.widget.TextView;

public class HelloRunneable implements Runnable 
{
	private TextView _associatedView;
	private int i = 10;
	
	public HelloRunneable(TextView associatedView)
	{
		_associatedView = associatedView;
	}

	@Override
	public void run() 
	{
		while (i >= 0)
		{
			try 
			{
				Thread.sleep(1000);
			}
			catch (InterruptedException e) 
			{
				e.printStackTrace();
			}
			
			_associatedView.post
			(
				new Runnable() 
					{
						public void run() 
						{
							_associatedView.setText(Integer.toString(i));
						}
					}
			);
			
			
			i--;
			
		}
	}

}


class UIUpdater implements Runnable
{
	@Override
	public void run() 
	{
		// TODO Auto-generated method stub
		
	}
	}