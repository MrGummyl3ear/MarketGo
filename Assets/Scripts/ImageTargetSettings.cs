using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageTargetSettings : MonoBehaviour {
    public List<GameObject> gameObject1s;
    public List<GameObject> gameObject2s;
    public List<GameObject> gameObject3s;
    // Use this for initialization
    void Start () {
        foreach (GameObject gameObject1 in gameObject1s)
        {
            gameObject1.transform.localPosition = new Vector3(PlayerPrefs.GetFloat("x1") / 100, 0f, PlayerPrefs.GetFloat("z1") / 90);
        }
        foreach (GameObject gameObject2 in gameObject1s)
        {
            gameObject2.transform.localPosition = new Vector3(PlayerPrefs.GetFloat("x2") / 100, 0f, PlayerPrefs.GetFloat("z2") / 90);
        }
        foreach (GameObject gameObject3 in gameObject1s)
        {
            gameObject3.transform.localPosition = new Vector3(PlayerPrefs.GetFloat("x3") / 100, 0f, PlayerPrefs.GetFloat("z3") / 90);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
