using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class SecondOptionLocation : MonoBehaviour
{
    private GameObject[] first;
    void Start()
    {
        double x = 0.5;
        double a = 1.04;
        double b = 0.61;
        double c = 0.175;
        float s = (float)x;
        float af = (float)a;
        float bf = (float)b;
        float cf = (float)c;
        first = GameObject.FindGameObjectsWithTag("Rate");
        if (PlayerPrefs.GetInt("FirstChoice") == 1)
        {
            foreach (GameObject r in first)
            {
                r.transform.position = new Vector3(r.transform.position.x, s, af);
            }
        }
        if (PlayerPrefs.GetInt("SecondChoice") == 1)
        {
            foreach (GameObject r in first)
            {
                r.transform.position = new Vector3(r.transform.position.x, s, bf);
            }
        }
        if (PlayerPrefs.GetInt("ThirdChoice") == 1)
        {
            foreach (GameObject r in first)
            {
                r.transform.position = new Vector3(r.transform.position.x, s, cf);
            }
        }
    }
}