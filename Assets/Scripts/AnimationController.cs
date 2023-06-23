using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimationController : MonoBehaviour
{

    public Animator Anim;
    int anim;
    int auto;

    void Start()
    {
        Anim = GetComponent<Animator>();
        auto = PlayerPrefs.GetInt("audio");
        Debug.Log(anim);

    }

    void FixedUpdate()
    {
        anim = PlayerPrefs.GetInt("anim");
        if (auto == 1 )
        {
            if (anim == 1)
            {
                Anim.Play("Test");
                Debug.Log("0");
            }
            if (anim == 2)
            {
                Anim.Play("Test");
                Debug.Log("0");
            }
        }
    } 
}