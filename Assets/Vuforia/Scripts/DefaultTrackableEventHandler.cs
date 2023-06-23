using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class DefaultTrackableEventHandler : MonoBehaviour, ITrackableEventHandler
{
 
    public AudioSource soundTarget;
    public AudioClip clipTarget;
    private AudioSource[] allAudioSources;
    public GameObject Listener; 

    void Awake()
    {
        Listener = GameObject.Find("ListenButton");
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

    #region PROTECTED_MEMBER_VARIABLES

    protected TrackableBehaviour mTrackableBehaviour;

    #endregion // PROTECTED_MEMBER_VARIABLES

    #region UNITY_MONOBEHAVIOUR_METHODS

    protected virtual void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
          { 
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
          }
        soundTarget = (AudioSource)gameObject.AddComponent<AudioSource>();
        Listener.SetActive(false);
    }

    protected virtual void OnDestroy()
    {
        if (mTrackableBehaviour)
            mTrackableBehaviour.UnregisterTrackableEventHandler(this);
    }
   #endregion // UNITY_MONOBEHAVIOUR_METHODS


#region PUBLIC_METHODS

/// <summary>
///     Implementation of the ITrackableEventHandler function called when the
///     tracking state changes.
/// </summary>
public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {
        int auto;
        int view;
        auto = PlayerPrefs.GetInt("audio");
        view = PlayerPrefs.GetInt("View");
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
            OnTrackingFound();
            if (view == 0 & auto==0 & Listener!=null) { 
            Listener.SetActive(true);
            }
            if (mTrackableBehaviour.TrackableName == "test_TEST")
            { 
                PlayerPrefs.SetInt("anim", 1);
              if (auto==1)
              {
                playSound("Audio/Sekretnye_materialy_-_X_Files_(Sms)_(ringon.pro)");
              }
            }
            if (mTrackableBehaviour.TrackableName == "104")
            {
                PlayerPrefs.SetInt("anim", 2);
                if (auto == 1)
                {
                    playSound("Audio/Anime-Eng");
                }
            }

        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                 newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
            OnTrackingLost();
            StopAllAudio();
            Listener.SetActive(false);
        }
        else
        {
            // For combo of previousStatus=UNKNOWN + newStatus=UNKNOWN|NOT_FOUND
            // Vuforia is starting, but tracking has not been lost or found yet
            // Call OnTrackingLost() to hide the augmentations
            OnTrackingLost();
        }
    }

    #endregion // PUBLIC_METHODS

    #region PROTECTED_METHODS

    protected virtual void OnTrackingFound()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        // Enable rendering:
        foreach (var component in rendererComponents)
            component.enabled = true;

        // Enable colliders:
        foreach (var component in colliderComponents)
            component.enabled = true;

        // Enable canvas':
        foreach (var component in canvasComponents)
            component.enabled = true;
    }


    protected virtual void OnTrackingLost()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        // Disable rendering:
        foreach (var component in rendererComponents)
            component.enabled = false;

        // Disable colliders:
        foreach (var component in colliderComponents)
            component.enabled = false;

        // Disable canvas':
        foreach (var component in canvasComponents)
            component.enabled = false;
    }

    #endregion // PROTECTED_METHODS
}
