using System.Collections;
using System.Collections.Generic;
using System.Resources;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraMechanicsRework : MonoBehaviour
{
    // CAMERA MECHANIC REWORK (TOGGLE BETWEEN DRAG OR ROTATE)

    //public Camera cameraObj;
    public GameObject myGameObj;
    public TMP_Text CameraButtonText;
    public Collider wormCollider;
    public Collider frogCollider;
    public Collider gooseCollider;
    public Collider wolfCollider;
    public Collider sparrowCollider;
    public Collider buzzardCollider;
    public Collider beaverCollider;
    public Collider flyCollider;
    public Collider beeCollider;

    private int cameraToggle = 1;
    public float speed = 2f;

    private int cameraDragSpeed = 20;

    float minFov = 80f;
    float maxFov = 100f;
    float sensitivity = 20f;

    private void Awake()
    {
        Camera.main.transform.rotation = Quaternion.Euler(0, 0, 0);
        Camera.main.transform.position = new Vector3(-4.87f, 0.23f, -4.17f);
        Camera.main.fieldOfView = 100f;
    }

    private void Start()
    {
        CameraButtonText.text = "Rotate";
        transform.LookAt(myGameObj.transform.position);
    }

    private void Update()
    {
        if (!GameObject.Find("Background"))
        {
            // CAMERA ROTATE
            if (cameraToggle == 0)
            {
                if (Input.GetMouseButton(0))
                {
                    //cameraObj.transform.RotateAround(myGameObj.transform.position, cameraObj.transform.up, -Input.GetAxis("Mouse X") * speed);
                    transform.RotateAround(myGameObj.transform.position, Vector3.up, -Input.GetAxis("Mouse X") * speed);
                }
            }

            // CAMERA DRAG
            if (cameraToggle == 1)
            {
                if (Input.GetMouseButton(0) && !GameObject.Find("wormText") && !GameObject.Find("frogText") && !GameObject.Find("gooseText") && !GameObject.Find("wolfText") && !GameObject.Find("sparrowText") && !GameObject.Find("buzzardText") && !GameObject.Find("beaverText") && !GameObject.Find("flyText") && !GameObject.Find("beeText"))
                {
                    float speed = cameraDragSpeed * Time.deltaTime;
                    Camera.main.transform.position -= new Vector3(Input.GetAxis("Mouse X") * speed, 0, Input.GetAxis("Mouse Y") * speed);
                    Camera.main.transform.position = new Vector3(Mathf.Clamp(transform.position.x, -16, 7), transform.position.y, Mathf.Clamp(transform.position.z, -8, 18));
                }
            }

            // CAMERA ZOOM
            var mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if ((wormCollider.bounds.IntersectRay(mouseRay) || GameObject.Find("wormText")) && !GameObject.Find("Frog"))
            {
                return;
            }

            if ((frogCollider.bounds.IntersectRay(mouseRay) || GameObject.Find("frogText")) && !GameObject.Find("Goose"))
            {
                return;
            }

            if ((gooseCollider.bounds.IntersectRay(mouseRay) || GameObject.Find("gooseText")) && !GameObject.Find("Wolf"))
            {
                return;
            }

            if ((wolfCollider.bounds.IntersectRay(mouseRay) || GameObject.Find("wolfText")) && !GameObject.Find("Bone"))
            {
                return;
            }

            if ((sparrowCollider.bounds.IntersectRay(mouseRay) || GameObject.Find("sparrowText")) && !GameObject.Find("Buzzard"))
            {
                return;
            }

            if ((buzzardCollider.bounds.IntersectRay(mouseRay) || GameObject.Find("buzzardText")) && !GameObject.Find("Beaver"))
            {
                return;
            }

            if ((beaverCollider.bounds.IntersectRay(mouseRay) || GameObject.Find("beaverText")) && !GameObject.Find("Beaver Station"))
            {
                return;
            }

            if ((flyCollider.bounds.IntersectRay(mouseRay) || GameObject.Find("flyText")) && !GameObject.Find("Fly Station"))
            {
                return;
            }

            if ((beeCollider.bounds.IntersectRay(mouseRay) || GameObject.Find("beeText")) && !GameObject.Find("Bee Station"))
            {
                return;
            }

            CameraZoom();
        }
    }

    private void CameraZoom()
    {
        float fov = Camera.main.fieldOfView;
        fov -= Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        fov = Mathf.Clamp(fov, minFov, maxFov);
        Camera.main.fieldOfView = fov;
    }

    // TOGGLE SCRIPT FOR BUTTON
    public void ToggleCameraMode()
    {
        if (!GameObject.Find("Background") && !GameObject.Find("wormText") && !GameObject.Find("frogText") && !GameObject.Find("gooseText") && !GameObject.Find("wolfText") && !GameObject.Find("sparrowText") && !GameObject.Find("buzzardText") && !GameObject.Find("beaverText") && !GameObject.Find("flyText") && !GameObject.Find("beeText"))
        {
            if (cameraToggle == 0)
            {
                cameraToggle = 1;
                CameraButtonText.text = "Drag";
                Camera.main.fieldOfView = 100f;
                Camera.main.transform.position = new Vector3(-4.87f, 0.23f, -4.17f);
                transform.LookAt(myGameObj.transform.position);
            }
            else if (cameraToggle == 1)
            {
                cameraToggle = 0;
                CameraButtonText.text = "Rotate";
                Camera.main.fieldOfView = 100f;
                //Camera.main.transform.position = myGameObj.transform.position + new Vector3(2, 4, 4);
                Camera.main.transform.position = new Vector3(-4.87f, 0.23f, -4.17f);
                transform.LookAt(myGameObj.transform.position);
            }
        }
    }
}
