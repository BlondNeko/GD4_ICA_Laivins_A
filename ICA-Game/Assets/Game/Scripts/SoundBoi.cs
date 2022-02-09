using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SoundBoi : MonoBehaviour
{
    //public static AudioClip staticNoise;

    public static AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        //staticNoise = Resources.Load<AudioClip>("Assets/Game/Audio/mixkit-static-electric-glitch-2597.wav");
        //source = GetComponent<AudioSource>();
    }

    public static void PlaySound()
    {
        source.Play();
    }

}
