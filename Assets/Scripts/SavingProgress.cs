using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingProgress : MonoBehaviour {
    public GameObject gameObject;
    public GameObject gameObjects;
    public GameObject gameObjecta;

    // Use this for initialization
    void Awake()
    {
        gameObject.transform.localPosition = new Vector3(PlayerPrefs.GetFloat("x1"), PlayerPrefs.GetFloat("y1"), PlayerPrefs.GetFloat("z1"));
        gameObjects.transform.localPosition = new Vector3(PlayerPrefs.GetFloat("x2"), PlayerPrefs.GetFloat("y2"), PlayerPrefs.GetFloat("z2"));
        gameObjecta.transform.localPosition = new Vector3(PlayerPrefs.GetFloat("x3"), PlayerPrefs.GetFloat("y3"), PlayerPrefs.GetFloat("z3"));
    }

}

