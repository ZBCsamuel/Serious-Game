﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicFadeScript : MonoBehaviour
{
    public AudioClip StartUpAudioClip;
    public AudioClip AmbientMusic;

    [Range(0.0f, 1.0f)]
    public float VolumeOnStartUp = 0.75f;
    [Range(0.0f, 1.0f)]
    public float VolumeOnAmbient = 0.5f;

    private AudioSource sound;

	// Use this for initialization
	void Start ()
	{
	    sound = GetComponent<AudioSource>();
	    sound.volume = VolumeOnStartUp;
        sound.clip = StartUpAudioClip;
	}

    private void Update()
    {
        if (!sound.isPlaying)
        {
            sound.volume = VolumeOnAmbient;
            sound.clip = AmbientMusic;
            sound.Play();
            sound.loop = true;
        }
    }
}
