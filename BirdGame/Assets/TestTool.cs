using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTool : MonoBehaviour
{
	public int index = 0;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") )
		{
			ScreenCapture.CaptureScreenshot(System.String.Format("Screenshot/Screenshot{0}.png", index ), 1);
			index++;
		}
    }
}
