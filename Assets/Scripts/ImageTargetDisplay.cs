using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageTargetDisplay : MonoBehaviour
{
    public ImageTarget target;
    public Text requirementsText;
    public Text warrantyText;
    public GameObject currentRate;

    void Start()
    {
        currentRate = target.rate;
        requirementsText.text = target.requirements;
        warrantyText.text = target.warranty;
    }
}
