using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SimpleMusicController : MonoBehaviour
{
    private AudioSource Music;
    public SimpleFloatData volume;
    // Start is called before the first frame update
    void Start()
    {
        Music.Play();
        Music.volume = 0.5F;
    }

    // Update is called once per frame
    void Update()
    {
        Music.volume = volume.value;
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
