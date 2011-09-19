package com.niko78.IFSGenerator;

import java.util.ArrayList;
import java.util.List;

import com.niko78.IFSGenerator.Drawing.Box;
import com.niko78.IFSGenerator.Drawing.BoxDrawer;
import com.niko78.IFSGenerator.Listeners.BoxParameter;
import com.niko78.IFSGenerator.Listeners.BoxParameterListener;
import com.niko78.IFSGenerator.Views.IFSView;

import android.app.Activity;
import android.os.Bundle;
import android.widget.EditText;

public class MainActivity extends Activity
{

    /**
     * Associated Box drawer
     */
    private BoxDrawer _boxDrawer;
    
    /**
     * Text Listeners
     */
    private List<BoxParameterListener> _textListeners;

	/** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState) 
    {
        super.onCreate(savedInstanceState);
        
        setContentView(R.layout.main);
        
        _boxDrawer = new BoxDrawer();
        _textListeners = new ArrayList<BoxParameterListener>();
        
        getIfsView().setBoxDrawer(_boxDrawer);
        
        SetListeners();
        
        RefreshParameters();
    }
   
    /**
     * Set EditText listeners 
     */
    private void SetListeners()
    {
    	// PosX Text changed Listener
    	BoxParameterListener boxPosXListener = new BoxParameterListener(BoxParameter.PosX, _boxDrawer, getIfsView());
    	EditText edtPosX = (EditText)findViewById(R.id.edPosX);
    	edtPosX.addTextChangedListener(boxPosXListener);
    	_textListeners.add(boxPosXListener);
    	
    	// PosY Text changed Listener
    	BoxParameterListener boxPosYListener = new BoxParameterListener(BoxParameter.PosY, _boxDrawer, getIfsView());
    	EditText edtPosY = (EditText)findViewById(R.id.edPosY);
    	edtPosY.addTextChangedListener(boxPosYListener);
    	_textListeners.add(boxPosYListener);
    	
    	// Width Text changed Listener
    	BoxParameterListener boxWidthListener = new BoxParameterListener(BoxParameter.Width, _boxDrawer, getIfsView());
    	EditText edtWidth = (EditText)findViewById(R.id.edWidth);
    	edtWidth.addTextChangedListener(boxWidthListener);    	
    	_textListeners.add(boxWidthListener);
    	
    	// Height Text changed Listener
    	BoxParameterListener boxHeigthListener = new BoxParameterListener(BoxParameter.Height, _boxDrawer, getIfsView());
    	EditText edtHeight = (EditText)findViewById(R.id.edHeight);
    	edtHeight.addTextChangedListener(boxHeigthListener);    
    	_textListeners.add(boxHeigthListener);
    }
    
    private IFSView getIfsView()
    {
    	return (IFSView)findViewById(R.id.ifsView);
    }
    
    private void EnableListeners()
    {
    	for (BoxParameterListener boxParameterListener : _textListeners)
    	{
    		boxParameterListener.Enabled = true;
		}
    }
    
    private void DisableListeners()
    {
    	for (BoxParameterListener boxParameterListener : _textListeners)
    	{
    		boxParameterListener.Enabled = false;
		}
    }
    
    private void RefreshParameters()
    {
    	Box box = _boxDrawer.GetSelectedBox();
    	
    	if (box == null)
    	{
    		return;
    	}
    	
    	DisableListeners();
    	
    	((EditText)findViewById(R.id.edPosX)).setText(Float.toString(box.getPosX()));
    	((EditText)findViewById(R.id.edPosY)).setText(Float.toString(box.getPosY()));
    	((EditText)findViewById(R.id.edWidth)).setText(Float.toString(box.getWidth()));
    	((EditText)findViewById(R.id.edHeight)).setText(Float.toString(box.getHeight()));
    	
    	EnableListeners();
    	
    }
    
}