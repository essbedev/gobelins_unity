using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interaction : GameEventListener, IInteraction
{
    public abstract void Play();
}
