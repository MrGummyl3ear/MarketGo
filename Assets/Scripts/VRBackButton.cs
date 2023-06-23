using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Vuforia;

public class VRBackButton : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbBtnObj;

    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("Btn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button released");
    }
}
