using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSettings : MonoBehaviour {
    public Toggle toggle;
	// Use this for initialization
	
	// Update is called once per frame
	void FixedUpdate () {
        toggle.onValueChanged.AddListener((value)=>
        {
            MyListener(value);
        });	
	}
    public void MyListener(bool value)
    {
        if (value)
        {
            PlayerPrefs.SetInt("audio",1);
            Debug.Log("1");
        }else
        {
            PlayerPrefs.SetInt("audio", 0);
            Debug.Log("0");
        }
    }
}
