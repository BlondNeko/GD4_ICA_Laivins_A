using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    //set up volume slider in setting menu following https://www.youtube.com/watch?v=YOaYQrN1oYQ 

    public AudioMixer mixer;

    public void SetVolume(float volume)
    {
        mixer.SetFloat("volume", volume);
    }
}
