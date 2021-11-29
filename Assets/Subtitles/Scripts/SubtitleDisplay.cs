using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubtitleDisplay : MonoBehaviour
{
    public Subtitles subtitles;
    private Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<Text>();
        subtitles.StartDisplay();
        subtitles.OnSubtitleDisplayed += OnDisplayed;
        _text.text = subtitles.Lines[subtitles.GetCurrentLine()];
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            subtitles.Next();
            if(!subtitles.IsDisplayed){
                _text.text = subtitles.Lines[subtitles.GetCurrentLine()];
            }
        }
    }

    private void OnDisplayed(int line){
        _text.enabled=false;
    }
}
