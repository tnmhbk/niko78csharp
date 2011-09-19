package com.niko78.IFSGenerator.Listeners;

import com.niko78.IFSGenerator.Drawing.BoxDrawer;

import android.text.Editable;
import android.text.TextWatcher;
import android.view.View;

/// Box Parameter Listener 
/**
 * @author Nicolas
 *
 */
public class BoxParameterListener implements TextWatcher 
{
	///Box Drawer
    private BoxDrawer _boxDrawer;
    
    // Box parameter Type
    private BoxParameter _boxParameter;
    
    // Associated View
    private View _view;
    
    /**
     * Indicates if Listener is enabled
     */
    public boolean Enabled;

    
	public BoxParameterListener(BoxParameter boxParameter, BoxDrawer boxDrawer, View view)	
	{
		_boxParameter = boxParameter;
		_boxDrawer = boxDrawer;
		_view = view;
		Enabled = true;
	}


	@Override
	public void afterTextChanged(Editable editable) 
	{
		if (editable.length() == 0)
		{
			editable.append("0");
			return;
		}
		
		if (Enabled)
		{
		   float value = Float.parseFloat(editable.toString());
		   _boxDrawer.setSelectedBoxParameter(_boxParameter, value);
		   _view.invalidate();
		}
	}

	@Override
	public void beforeTextChanged(CharSequence arg0, int arg1, int arg2, int arg3) 
	{
	}

	@Override
	public void onTextChanged(CharSequence arg0, int arg1, int arg2, int arg3) 
	{
	}

}

