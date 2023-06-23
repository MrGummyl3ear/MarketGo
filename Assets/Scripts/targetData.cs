using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Vuforia
{
    public class targetData : MonoBehaviour
    {
        public AudioSource soundTarget;
        public AudioClip clipTarget;

        void Start()
        {
            soundTarget = (AudioSource)gameObject.AddComponent<AudioSource>();
        }

        void Update()
        {
            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

            foreach (TrackableBehaviour tb in tbs)
            {
                string name = tb.TrackableName;
                ImageTarget it = tb.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);

                if (name == "ImageTarget")
                {
                    playSound("Audio/Sekretnye_materialy_-_X_Files_(Sms)_(ringon.pro)");
                    Debug.Log("0");
                }
            }
        }

        //function to play sound
        void playSound(string ss)
        {
            clipTarget = (AudioClip)Resources.Load(ss);
            soundTarget.clip = clipTarget;
            soundTarget.loop = false;
            soundTarget.playOnAwake = false;
            soundTarget.Play();
        }
    }
}


