using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneController.Instance.LoadScene("Environment");
        SceneController.Instance.LoadScene("Props");
    }

    void OnGUI()
    {
        if(GUI.Button(new Rect(10,10,100,40), "Unload Props")){
            SceneController.Instance.UnloadScene("Props");
        }
    }
}
