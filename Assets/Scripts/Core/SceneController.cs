using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : Singleton<SceneController>
{
    public void LoadScene(string scene, bool add = true){
        SceneManager.LoadSceneAsync(scene, add ? LoadSceneMode.Additive : LoadSceneMode.Single);
    }

    public void UnloadScene(string scene){
        SceneManager.UnloadSceneAsync(scene);
    }
}
