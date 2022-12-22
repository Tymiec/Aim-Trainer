using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    private float xRotation = 0f;
    private float xSensitivity = 10f;
    private float ySensitivity = 10f;

    public void ProccessLook(Vector2 input)
    {
        // lock the mouse cursor
        Cursor.lockState = CursorLockMode.Locked;

        float mouseX = input.x;
        float mouseY = input.y;

        xRotation -= (mouseY * xSensitivity * Time.deltaTime);
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        cam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
    }
}
