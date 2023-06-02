using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] playliste;
    public AudioSource audioSource;

       
    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = playliste[0];
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
