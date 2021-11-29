using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Subtitle/Subtitles")]
public class Subtitles : ScriptableObject
{

    public delegate void SubtitleEvent(int currentLine);
    public event SubtitleEvent OnSubtitleChange;
    public event SubtitleEvent OnSubtitleDisplayed;

    public List<string> Lines;

    public bool IsDisplayed = false;

    private int _currentLine;

    public int GetCurrentLine(){
        return _currentLine;
    }

    public void StartDisplay(){
        _currentLine = 0;
    }

    public bool HasNext(){
        return (_currentLine < Lines.Count-1);
    }

    public void Next(){
        if(HasNext()){
            _currentLine++;
            if(OnSubtitleChange != null) OnSubtitleChange(_currentLine);
        }else{
            IsDisplayed = true;
            if(OnSubtitleDisplayed != null) OnSubtitleDisplayed(_currentLine);
        }
    }

}
