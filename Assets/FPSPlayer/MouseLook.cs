using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform player;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private float xRot = 0f;
    void Update()
    {
        float xRotation = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float yRotation = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRot -= yRotation;
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRot, 0, 0);
        player.Rotate(Vector3.up * xRotation);
    }
}
