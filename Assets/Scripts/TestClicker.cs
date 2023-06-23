using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClicker : MonoBehaviour {
    public AudioSource soundTarget;
    public AudioClip clipTarget;
    public Animator cubeAni;
    private AudioSource[] allAudioSources;
    int anim;
    int auto;
    bool ispressed;
    bool used;

    // Use this for initialization
    void Start()
    {
        cubeAni.GetComponent<Animator>();
        auto = PlayerPrefs.GetInt("audio");
        soundTarget = (AudioSource)gameObject.AddComponent<AudioSource>();
    }

    void StopAllAudio()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }
    }

    void playSound(string ss)
    {
        clipTarget = (AudioClip)Resources.Load(ss);
        soundTarget.clip = clipTarget;
        soundTarget.loop = true;
        soundTarget.playOnAwake = false;
        soundTarget.Play();
    }
    public void Checking()
    {
        if (auto == 0)
        {
            used = false;
            if (ispressed == false & used == false)
            {
                Listening();
                used = true;
            }
            if (ispressed == true & used == false)
            {
                Unlistening();
                used = true;
            }
        }
    }
    public void Listening() {
        Debug.Log("Button pressed");
        cubeAni.Play("Test");
        playSound("Audio/Sekretnye_materialy_-_X_Files_(Sms)_(ringon.pro)");
        ispressed = true;
    }
    public void Unlistening()
    {
        Debug.Log("Button released");
        cubeAni.Play("New State");
        StopAllAudio();
        ispressed = false;
    }
}


