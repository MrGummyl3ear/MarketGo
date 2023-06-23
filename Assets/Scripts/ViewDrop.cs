using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewDrop : MonoBehaviour {
    public Dropdown ViewDropdown;
    void Start()
    {
    if (PlayerPrefs.HasKey("View"))
        ViewDropdown.value=PlayerPrefs.GetInt("View");
    }
    void Update ()
    {
            switch (ViewDropdown.value)
        {
            case 0:
                PlayerPrefs.SetInt("View", 0);
                break;
            case 1:
                PlayerPrefs.SetInt("View", 1);
                break;
        }
    }
}
