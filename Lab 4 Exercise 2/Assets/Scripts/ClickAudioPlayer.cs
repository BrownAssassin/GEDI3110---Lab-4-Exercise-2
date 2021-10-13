using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAudioPlayer : MonoBehaviour
{
    private AudioSource _audiosource;
    public AudioClip _clickSound;

    private void Awake()
    {
        _audiosource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        ClickCharge.clicked += PlayAudio;
    }

    private void OnDisable()
    {
        ClickCharge.clicked -= PlayAudio;
    }

    private void PlayAudio()
    {
        _audiosource.PlayOneShot(_clickSound);
    }
}
