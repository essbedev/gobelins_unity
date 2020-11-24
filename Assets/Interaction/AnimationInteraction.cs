using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationInteraction : Interaction
{

    private Animator _anim;

    public override void Play()
    {
        _anim.SetTrigger("Flip");
    }

    void Start()
    {
        _anim = GetComponent<Animator>();
    }
}
