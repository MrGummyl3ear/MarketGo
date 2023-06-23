using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChoicesDrop : MonoBehaviour {
    public Dropdown Dropdown1;
    public Dropdown Dropdown2;
    public Dropdown Dropdown3;
    void Awake()
    {
        if (PlayerPrefs.HasKey("FirstChoice"))
            Dropdown1.value = PlayerPrefs.GetInt("FirstChoice");
        if (PlayerPrefs.HasKey("FirstChoice"))
            Dropdown2.value = PlayerPrefs.GetInt("SecondChoice");
        if (PlayerPrefs.HasKey("FirstChoice"))
            Dropdown3.value = PlayerPrefs.GetInt("ThirdChoice");
    }
    void Start() {
        if (Dropdown1.value == Dropdown2.value)
            if (Dropdown2.value == Dropdown3.value)
            {
                Dropdown2.value++;
                Dropdown3.value = 3;
            }   
    }

    // Update is called once per frame
    void Update () {
        switch (Dropdown1.value)
        {
            case 0:
                PlayerPrefs.SetInt("FirstChoice", 0);
                break;
            case 1:
                PlayerPrefs.SetInt("FirstChoice", 1);
                break;
            case 2:
                PlayerPrefs.SetInt("FirstChoice", 2);
                break;
        }
        switch (Dropdown2.value)
        {
            case 0:
                PlayerPrefs.SetInt("SecondChoice", 0);
                break;
            case 1:
                PlayerPrefs.SetInt("SecondChoice", 1);
                break;
            case 2:
                PlayerPrefs.SetInt("SecondChoice", 2);
                break;
        }
        switch (Dropdown3.value)
        {
            case 0:
                PlayerPrefs.SetInt("ThirdChoice", 0);
                break;
            case 1:
                PlayerPrefs.SetInt("ThirdChoice", 1);
                break;
            case 2:
                PlayerPrefs.SetInt("ThirdChoice", 2);
                break;
        }           
    }
}
