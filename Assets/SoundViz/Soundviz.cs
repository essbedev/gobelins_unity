using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundviz : MonoBehaviour
{
    public GameObject soundBar;
    public float radius = 10f;
    public float maxScale = 80f;
    public float particleThreshold = .05f;

    private AudioSource _source;

    private float[] _samples;
    private GameObject[] _bars;
    private ParticleSystem[] _particles;

    // Start is called before the first frame update
    void Start()
    {
        _source = GetComponent<AudioSource>();
        _samples = new float[256];
        _bars = new GameObject[_samples.Length];
        _particles = new ParticleSystem[_samples.Length];
        
        GameObject bar;
        float a = (Mathf.PI*2f)/_samples.Length;
        for (int i = 0; i < _samples.Length; i++)
        {
            bar = Instantiate<GameObject>(soundBar, transform);
            bar.transform.position = new Vector3(Mathf.Sin(a*i)*radius, 0f, Mathf.Cos(a*i)*radius);
            _particles[i] = bar.GetComponentInChildren<ParticleSystem>();

            _bars[i] = bar;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _source.GetSpectrumData(_samples, 1, FFTWindow.Blackman);
        GameObject bar;
        Vector3 scale;
        Vector3 prev;
        for (int i = 0; i < _samples.Length; i++)
        {
            bar = _bars[i];
            prev = scale = bar.transform.localScale;
            scale.y = _samples[i]*maxScale;
            bar.transform.localScale = Vector3.Lerp(scale, prev, .99f);

            if(_samples[i] > particleThreshold){
                _particles[i].Play();
            }
        }
    }
}
