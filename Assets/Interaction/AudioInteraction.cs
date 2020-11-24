using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioInteraction : Interaction
{

    private AudioSource _source;
    
    public override void Play()
    {
        _source.Play();   
    }

    void Start()
    {
        _source = GetComponent<AudioSource>();
    }
}
