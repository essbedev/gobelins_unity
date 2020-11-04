using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class FadeAudio : MonoBehaviour
{

    public AudioMixer mixer;
    public float fadeDuration = 5.0f;

    private bool _isFading = false;
    private bool _toggle = false;

    void Start()
    {
        mixer.SetFloat("Ambiance1Volume", 0);
        mixer.SetFloat("Ambiance2Volume", -80);
    }

    void OnGUI()
    {
        if (!_isFading && GUI.Button(new Rect(10, 10, 100, 30), "Fade"))
        {
            _toggle = !_toggle;
            _isFading = true;
            StartCoroutine(FadeAmbiances());
        }
    }

    private IEnumerator FadeAmbiances()
    {
        float time = 0f;
        float progress = 0f;
        while (time <= fadeDuration)
        {
            time += Time.deltaTime;
            progress = time / fadeDuration;
            mixer.SetFloat("Ambiance1Volume", _toggle?(-80f*progress):(-80+80*progress));
            mixer.SetFloat("Ambiance2Volume", _toggle?(-80+80*progress):(-80f*progress));
            yield return null;
        }
        _isFading = false;
    }
}
