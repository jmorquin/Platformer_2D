using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] playliste;
    public AudioSource audioSource;
    private int musicIndex = 0;

       
    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = playliste[0];
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying ) 
        
        {
            PlayNextSong();
        }
        
    }
    void PlayNextSong()
    {
        musicIndex = (musicIndex + 1) % playliste.Length;
        audioSource.clip = playliste[musicIndex];
        audioSource.Play();
    }

}
