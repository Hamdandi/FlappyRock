using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("---Audio Sources---")]
    [SerializeField] AudioSource musiceSource;
    [SerializeField] AudioSource SFXSource;

    [Header("---Audio Clips---")]
    public AudioClip backgroundMusic;
    public AudioClip death;

    private void Start()
    {
        musiceSource.clip = backgroundMusic;
        musiceSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.clip = clip;
        SFXSource.Play();
    }
}
