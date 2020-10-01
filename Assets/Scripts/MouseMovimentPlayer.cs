using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovimentPlayer : MonoBehaviour
{
    public float sensitivity = 100f;
    public Transform bodyPleyer;
    float xRotate = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotate -= mouseY;
        xRotate = Mathf.Clamp(xRotate, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);

        bodyPleyer.Rotate(Vector3.up * mouseX);
    }
}
