using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager1 : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    //[SerializeField] AudioSource SFXSource;

    public AudioClip background;
    //public AudioClip buttonClick;
    //public AudioClip walking;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }
}
