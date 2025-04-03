using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SimpleMusicController : MonoBehaviour
{
    private AudioSource Music;
    // Start is called before the first frame update
    void Start()
    {
        Music.Play();
        Music.volume = 0.5f;
    }

    void PauseMusic()
    {
        Music.Pause();
    }

    void PlayMusic()
    {
        Music.Play();
    }
}
