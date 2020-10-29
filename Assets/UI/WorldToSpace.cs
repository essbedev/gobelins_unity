using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldToSpace : MonoBehaviour
{

public Camera cam;
public Transform cube;
public Image img;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = cam.WorldToScreenPoint(cube.position);
        Debug.Log(pos);
        Vector3 rPos = Vector3.zero;
        rPos.x = pos.x - Screen.width*.5f;
        rPos.y = pos.y-Screen.height*.5f;
        img.rectTransform.localPosition = rPos;
    }
}
