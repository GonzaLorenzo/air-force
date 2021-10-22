using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public KeyCode      PauseKey = KeyCode.Escape;
    public GameObject   PauseContainer;
    public AudioSource  StageMusic;
    [Range(0f, 1f)]

    public float VolumeMultiplierWhenPaused;

    public float OriginalMusicVolume;

    private void Update()
    {
        if(Input.GetKeyDown(PauseKey))
        {
            PauseContainer.SetActive(!PauseContainer.activeSelf);

            if(PauseContainer.activeSelf)
            {
                Time.timeScale = 0f;
                StageMusic.volume = OriginalMusicVolume * VolumeMultiplierWhenPaused;
            }
            else
            {
                Time.timeScale = 1f;
                StageMusic.volume = OriginalMusicVolume;
            }
        }
    }
}
