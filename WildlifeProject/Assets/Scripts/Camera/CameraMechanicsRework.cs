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

    float TouchZoomSpeed = 0.1f;
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
        CameraButtonText.text = "Drag";
        transform.LookAt(myGameObj.transform.position);
    }

    private void Update()
    {
        if (!GameObject.Find("Background"))
        {
            // CAMERA ROTATE
            if (cameraToggle == 0 && (Input.GetMouseButton(0) || Input.touchCount == 1))
            {
                //cameraObj.transform.RotateAround(myGameObj.transform.position, cameraObj.transform.up, -Input.GetAxis("Mouse X") * speed);
                transform.RotateAround(myGameObj.transform.position, Vector3.up, -Input.GetAxis("Mouse X") * speed);
            }

            // CAMERA DRAG
            if (cameraToggle == 1 && (Input.GetMouseButton(0) || Input.touchCount == 1))
            {
                if (!GameObject.Find("Hex Button Worm") && !GameObject.Find("Hex Button Frog") && !GameObject.Find("Hex Button Buzzard") && !GameObject.Find("Hex Button Fly") && !GameObject.Find("Hex Button Wolf") && !GameObject.Find("wormText") && !GameObject.Find("frogText") && !GameObject.Find("gooseText") && !GameObject.Find("wolfText") && !GameObject.Find("sparrowText") && !GameObject.Find("buzzardText") && !GameObject.Find("beaverText") && !GameObject.Find("flyText") && !GameObject.Find("beeText"))
                {
                    float speedDrag = cameraDragSpeed * Time.deltaTime;
                    Camera.main.transform.position -= new Vector3(Input.GetAxis("Mouse X") * speedDrag, 0, Input.GetAxis("Mouse Y") * speedDrag);
                    Camera.main.transform.position = new Vector3(Mathf.Clamp(transform.position.x, -16, 7), transform.position.y, Mathf.Clamp(transform.position.z, -8, 18));
                }
            }

            // CAMERA ZOOM
            var mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if ((wormCollider.bounds.IntersectRay(mouseRay) || GameObject.Find("wormText")) && !GameObject.Find("Frog"))
            {
                return;
            }

            if (GameObject.Find("Hex Button Worm"))
            {
                return;
            }

            if (GameObject.Find("Hex Button Frog"))
            {
                return;
            }

            if (GameObject.Find("Hex Button Buzzard"))
            {
                return;
            }

            if (GameObject.Find("Hex Button Wolf"))
            {
                return;
            }

            if (GameObject.Find("Hex Button Fly"))
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

            CameraZoom(); // PC

            // MOBILE PINCH ZOOM
            if (Input.touchCount == 2)
            {
                Touch tZero = Input.GetTouch(0);
                Touch tOne = Input.GetTouch(1);

                Vector2 tZeroPrevious = tZero.position - tZero.deltaPosition;
                Vector2 tOnePrevious = tOne.position - tOne.deltaPosition;

                float oldTouchDistance = Vector2.Distance(tZeroPrevious, tOnePrevious);
                float currentTouchDistance = Vector2.Distance(tZero.position, tOne.position);

                float deltaDistance = oldTouchDistance - currentTouchDistance;
                Zoom(deltaDistance, TouchZoomSpeed);
            }

            if (Camera.main.fieldOfView < minFov)
            {
                Camera.main.fieldOfView = 80f;
            }
            else
            if (Camera.main.fieldOfView > maxFov)
            {
                Camera.main.fieldOfView = 100f;
            }
        }
    }

    private void CameraZoom()
    {
        float fov = Camera.main.fieldOfView;
        fov -= Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        fov = Mathf.Clamp(fov, minFov, maxFov);
        Camera.main.fieldOfView = fov;
    }

    void Zoom(float deltaMagnitudeDiff, float speed)
    {
        Camera.main.fieldOfView += deltaMagnitudeDiff * speed;
        Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, minFov, maxFov);
    }

    // TOGGLE SCRIPT FOR BUTTON
    public void ToggleCameraMode()
    {
        if (!GameObject.Find("Background") && !GameObject.Find("Hex Button Worm") && !GameObject.Find("Hex Button Frog") && !GameObject.Find("Hex Button Buzzard") && !GameObject.Find("Hex Button Fly") && !GameObject.Find("Hex Button Wolf") && !GameObject.Find("wormText") && !GameObject.Find("frogText") && !GameObject.Find("gooseText") && !GameObject.Find("wolfText") && !GameObject.Find("sparrowText") && !GameObject.Find("buzzardText") && !GameObject.Find("beaverText") && !GameObject.Find("flyText") && !GameObject.Find("beeText"))
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
