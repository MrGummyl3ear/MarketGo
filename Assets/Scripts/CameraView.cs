using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CameraView : MonoBehaviour {
    int data;
    void Start()
    {
     data = PlayerPrefs.GetInt("View");  
        if (data==0)
            {
            MixedRealityController.Instance.SetMode(MixedRealityController.Mode.HANDHELD_AR);
            }
        else
        {
            MixedRealityController.Instance.SetMode(MixedRealityController.Mode.VIEWER_AR);
        }
    }
}
