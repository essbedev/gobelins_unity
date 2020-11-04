using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class FadeSnapshots : MonoBehaviour
{
    public float fadeDuration = 2.0f;

    public AudioMixerSnapshot ambiance1;
    public AudioMixerSnapshot ambiance2;

    private bool _toggle;

    // Start is called before the first frame update
    void Start()
    {
        ambiance1.TransitionTo(0);
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 150, 30), "Fade Snapshots")){
            _toggle = !_toggle;
            if(_toggle){
                ambiance2.TransitionTo(fadeDuration);
            }else{
                ambiance1.TransitionTo(fadeDuration);
            }
        }
    }
}
