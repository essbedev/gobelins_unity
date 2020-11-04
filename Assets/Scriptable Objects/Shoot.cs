using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public PlayerHealth health;
    public LayerMask playerLayer;

    private Camera _cam;

    // Start is called before the first frame update
    void Start()
    {
        _cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            RaycastHit hit;
            Ray ray = _cam.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, Mathf.Infinity, playerLayer)){
                health.TakeHit();
            }
        }
    }
}
