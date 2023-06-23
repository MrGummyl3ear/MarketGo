using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLog : MonoBehaviour {

	// Use this for initialization
	void Update () {
        Debug.Log(transform.position.z);
        Debug.Log(transform.position.y);
    }
}
