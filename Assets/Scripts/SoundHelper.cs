using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHelper : MonoBehaviour
{
    static private SoundHelper myInstance;

    public AudioSource myAudioSource;
    private void Awake()
    {
        if (myInstance == null)
        {
            myInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
        }
    }

    static public void PlaySound(AudioClip ClipToPlay)
    {
        if (myInstance != null)
            {
            myInstance.myAudioSource.PlayOneShot(ClipToPlay);
        }
    }

}
