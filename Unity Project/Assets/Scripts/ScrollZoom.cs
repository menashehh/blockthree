using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScrollZoom : MonoBehaviour
{
    // float ROTSpeed = 10f;

    float minFov = 20f;
    float maxFov = 60f;
    float sensitivity = 20f;

    // Update is called once per frame
    void Update()
    {
        // gameObject.transform.Translate(0, 0, Input.GetAxis("Mouse ScrollWheel") * ROTSpeed);

        float fov = Camera.main.fieldOfView;
        fov -= Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        fov = Mathf.Clamp(fov, minFov, maxFov);
        Camera.main.fieldOfView = fov;
    }
}
