using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [Header("------Audio Source---")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("------Audio Clip---")]
    public AudioClip background;
    public AudioClip damage;
    public AudioClip collect;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.loop = true; // Faz o áudio repetir automaticamente
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

}
