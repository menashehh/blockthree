using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScrollZoom : MonoBehaviour
{
    // float ROTSpeed = 10f;

    float minFov = 40f; //20f
    float maxFov = 60f;
    float sensitivity = 20f;

    void Update()
    {
        // gameObject.transform.Translate(0, 0, Input.GetAxis("Mouse ScrollWheel") * ROTSpeed);

        // Zoom in or zoom our only if the NPC name text is hidden
        if (!GameObject.Find("NPC2").GetComponent<NpcShowName>().Object.activeSelf)
        {
            float fov = Camera.main.fieldOfView;
            fov -= Input.GetAxis("Mouse ScrollWheel") * sensitivity;
            fov = Mathf.Clamp(fov, minFov, maxFov);
            Camera.main.fieldOfView = fov;
        }
    }
}
