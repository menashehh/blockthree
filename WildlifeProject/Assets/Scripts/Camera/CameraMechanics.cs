using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraMechanics : MonoBehaviour
{
    public Camera cameraObj;
    public GameObject myGameObj;
    public Collider frogCollider;
    public Collider wormCollider;
    public Collider wolfCollider;

    public float speed = 2f;

    float minFov = 40f;
    float maxFov = 60f;
    float sensitivity = 20f;

    private void Awake()
    {
        cameraObj.transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    void Update()
    {
        if (!GameObject.Find("Background"))
        {
            transform.LookAt(myGameObj.transform.position);
            RotateCamera();

            // Camera Zoom

            var mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (!GameObject.Find("Worm"))
            {
                if (!GameObject.Find("frogText") && !frogCollider.bounds.IntersectRay(mouseRay))
                {
                    float fov = Camera.main.fieldOfView;
                    fov -= Input.GetAxis("Mouse ScrollWheel") * sensitivity;
                    fov = Mathf.Clamp(fov, minFov, maxFov);
                    Camera.main.fieldOfView = fov;
                }
            }
            else if (!GameObject.Find("Wolf"))
            {
                if (!GameObject.Find("wormText") && !wormCollider.bounds.IntersectRay(mouseRay))
                {
                    float fov = Camera.main.fieldOfView;
                    fov -= Input.GetAxis("Mouse ScrollWheel") * sensitivity;
                    fov = Mathf.Clamp(fov, minFov, maxFov);
                    Camera.main.fieldOfView = fov;
                }
            }
            else if (!GameObject.Find("Wolf House"))
            {
                if (!GameObject.Find("wolfText") && !wolfCollider.bounds.IntersectRay(mouseRay))
                {
                    float fov = Camera.main.fieldOfView;
                    fov -= Input.GetAxis("Mouse ScrollWheel") * sensitivity;
                    fov = Mathf.Clamp(fov, minFov, maxFov);
                    Camera.main.fieldOfView = fov;
                }
            }
        }
    }

    void RotateCamera()
    {
        // Camera Pan

        if (Input.GetMouseButton(0))
        {
            cameraObj.transform.RotateAround(myGameObj.transform.position, cameraObj.transform.up, -Input.GetAxis("Mouse X") * speed);
        }
    }
}
