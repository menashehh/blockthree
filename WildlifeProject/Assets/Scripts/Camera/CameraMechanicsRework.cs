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
    public int cameraToggle = 1;
    public float speed = 2f;

    private int cameraDragSpeed = 60;

    float minFov = 30f;
    float maxFov = 80f;
    float sensitivity = 70f;

    private void Awake()
    {
        Camera.main.transform.rotation = Quaternion.Euler(0, 0, 0);
        Camera.main.transform.position = new Vector3(-4.87f, 0.23f, -4.17f);
        Camera.main.fieldOfView = 65f;
    }

    private void Start()
    {
        CameraButtonText.text = "Drag";
        transform.LookAt(myGameObj.transform.position);
    }

    private void Update()
    {
        if (!GameObject.Find("Background") && !GameObject.Find("BackgroundOverlay"))
        {
            // CAMERA ROTATE
            if (cameraToggle == 0 && (Input.GetMouseButton(0) || Input.touchCount == 1))
            {
                if (!GameObject.Find("Hex Button Worm") && !GameObject.Find("Hex Button Worm 2") && !GameObject.Find("Hex Button Worm 3") && !GameObject.Find("Hex Button Worm 4")
                    && !GameObject.Find("Hex Button Frog") && !GameObject.Find("Hex Button Frog 2") && !GameObject.Find("Hex Button Frog 3")
                    && !GameObject.Find("Hex Button Sparrow") && !GameObject.Find("Hex Button Sparrow 2")
                    && !GameObject.Find("Hex Button Buzzard") && !GameObject.Find("Hex Button Buzzard 2")
                    && !GameObject.Find("Hex Button Fly") && !GameObject.Find("Hex Button Fly 2")
                    && !GameObject.Find("Hex Button Wolf") && !GameObject.Find("Hex Button Wolf 2")
                    && !GameObject.Find("Hex Button Goose")
                    && !GameObject.Find("Hex Button Bee")
                    && !GameObject.Find("Hex Button Beaver")
                    && !GameObject.Find("Restrict Button")
                    && !GameObject.Find("wormText") && !GameObject.Find("frogText") && !GameObject.Find("gooseText") && !GameObject.Find("wolfText")
                    && !GameObject.Find("sparrowText") && !GameObject.Find("buzzardText") && !GameObject.Find("beaverText") && !GameObject.Find("flyText") && !GameObject.Find("beeText"))
                {
                    //cameraObj.transform.RotateAround(myGameObj.transform.position, cameraObj.transform.up, -Input.GetAxis("Mouse X") * speed);
                    transform.RotateAround(myGameObj.transform.position, Vector3.up, -Input.GetAxis("Mouse X") * speed);
                }
            }

            // CAMERA DRAG
            if (cameraToggle == 1 && (Input.GetMouseButton(0) || Input.touchCount == 1))
            {
                if (!GameObject.Find("Hex Button Worm") && !GameObject.Find("Hex Button Worm 2") && !GameObject.Find("Hex Button Worm 3") && !GameObject.Find("Hex Button Worm 4")
                    && !GameObject.Find("Hex Button Frog") && !GameObject.Find("Hex Button Frog 2") && !GameObject.Find("Hex Button Frog 3") 
                    && !GameObject.Find("Hex Button Sparrow") && !GameObject.Find("Hex Button Sparrow 2")
                    && !GameObject.Find("Hex Button Buzzard") && !GameObject.Find("Hex Button Buzzard 2")
                    && !GameObject.Find("Hex Button Fly") && !GameObject.Find("Hex Button Fly 2")
                    && !GameObject.Find("Hex Button Wolf") && !GameObject.Find("Hex Button Wolf 2")
                    && !GameObject.Find("Hex Button Goose")
                    && !GameObject.Find("Hex Button Bee")
                    && !GameObject.Find("Hex Button Beaver")
                    && !GameObject.Find("Restrict Button")
                    && !GameObject.Find("wormText") && !GameObject.Find("frogText") && !GameObject.Find("gooseText") && !GameObject.Find("wolfText")
                    && !GameObject.Find("sparrowText") && !GameObject.Find("buzzardText") && !GameObject.Find("beaverText") && !GameObject.Find("flyText") && !GameObject.Find("beeText"))
                {
                    float speedDrag = cameraDragSpeed * Time.deltaTime;
                    Camera.main.transform.position -= new Vector3(Input.GetAxis("Mouse X") * speedDrag, 0, Input.GetAxis("Mouse Y") * speedDrag);
                    Camera.main.transform.position = new Vector3(Mathf.Clamp(transform.position.x, -16, 7), transform.position.y, Mathf.Clamp(transform.position.z, -8, 18));
                    
                    myGameObj.transform.position = Camera.main.transform.position;
                }
            }

            // CAMERA ZOOM
            var mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (GameObject.Find("Restrict Button")) return;

            if (GameObject.Find("Build Button Worm") || GameObject.Find("Hex Button Worm") || GameObject.Find("Hex Button Worm 2") || GameObject.Find("Hex Button Worm 3") || GameObject.Find("Hex Button Worm 4"))
            {
                return;
            }

            if (GameObject.Find("Build Button Frog") || GameObject.Find("Hex Button Frog") || GameObject.Find("Hex Button Frog 2") || GameObject.Find("Hex Button Frog 3"))
            {
                return;
            }

            if (GameObject.Find("Build Button Sparrow") || GameObject.Find("Hex Button Sparrow") || GameObject.Find("Hex Button Sparrow 2"))
            {
                return;
            }

            if (GameObject.Find("Build Button Buzzard") || GameObject.Find("Hex Button Buzzard") || GameObject.Find("Hex Button Buzzard 2"))
            {
                return;
            }

            if (GameObject.Find("Build Button Wolf") || GameObject.Find("Hex Button Wolf") || GameObject.Find("Hex Button Wolf 2"))
            {
                return;
            }

            if (GameObject.Find("Build Button Fly") || GameObject.Find("Hex Button Fly") || GameObject.Find("Hex Button Fly 2"))
            {
                return;
            }

            if (GameObject.Find("Build Button Goose") || GameObject.Find("Hex Button Goose"))
            {
                return;
            }

            if (GameObject.Find("Build Button Beaver") || GameObject.Find("Hex Button Beaver"))
            {
                return;
            }

            if (GameObject.Find("Build Button Bee") || GameObject.Find("Hex Button Bee"))
            {
                return;
            }

            /*
            if (wormCollider.bounds.IntersectRay(mouseRay) || GameObject.Find("wormText"))
            {
                return;
            }

            if (frogCollider.bounds.IntersectRay(mouseRay) || GameObject.Find("frogText"))
            {
                return;
            }

            if (gooseCollider.bounds.IntersectRay(mouseRay) || GameObject.Find("gooseText"))
            {
                return;
            }

            if (wolfCollider.bounds.IntersectRay(mouseRay) || GameObject.Find("wolfText"))
            {
                return;
            }

            if (sparrowCollider.bounds.IntersectRay(mouseRay) || GameObject.Find("sparrowText"))
            {
                return;
            }

            if (buzzardCollider.bounds.IntersectRay(mouseRay) || GameObject.Find("buzzardText"))
            {
                return;
            }

            if (beaverCollider.bounds.IntersectRay(mouseRay) || GameObject.Find("beaverText"))
            {
                return;
            }

            if (flyCollider.bounds.IntersectRay(mouseRay) || GameObject.Find("flyText"))
            {
                return;
            }

            if (beeCollider.bounds.IntersectRay(mouseRay) || GameObject.Find("beeText"))
            {
                return;
            }
            */

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
                Camera.main.fieldOfView = 45f;
            }
            else
            if (Camera.main.fieldOfView > maxFov)
            {
                Camera.main.fieldOfView = 80f;
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
        if (!GameObject.Find("Background") && !GameObject.Find("BackgroundOverlay") && !GameObject.Find("Hex Button Worm") && !GameObject.Find("Hex Button Worm 2") && !GameObject.Find("Hex Button Worm 3") && !GameObject.Find("Hex Button Worm 4")
                    && !GameObject.Find("Hex Button Frog") && !GameObject.Find("Hex Button Frog 2") && !GameObject.Find("Hex Button Frog 3")
                    && !GameObject.Find("Hex Button Sparrow") && !GameObject.Find("Hex Button Sparrow 2")
                    && !GameObject.Find("Hex Button Buzzard") && !GameObject.Find("Hex Button Buzzard 2")
                    && !GameObject.Find("Hex Button Fly") && !GameObject.Find("Hex Button Fly 2")
                    && !GameObject.Find("Hex Button Wolf") && !GameObject.Find("Hex Button Wolf 2")
                    && !GameObject.Find("Hex Button Goose")
                    && !GameObject.Find("Hex Button Bee")
                    && !GameObject.Find("Hex Button Beaver")
                    && !GameObject.Find("Restrict Button")
                    && !GameObject.Find("wormText") && !GameObject.Find("frogText") && !GameObject.Find("gooseText") && !GameObject.Find("wolfText")
                    && !GameObject.Find("sparrowText") && !GameObject.Find("buzzardText") && !GameObject.Find("beaverText") && !GameObject.Find("flyText") && !GameObject.Find("beeText"))
        {
            if (cameraToggle == 0)
            {
                cameraToggle = 1;
                CameraButtonText.text = "Drag";
                Camera.main.fieldOfView = 80f;
                transform.LookAt(myGameObj.transform.position);
                Camera.main.transform.rotation = Quaternion.Euler(41, -4, 0);
            }
            else if (cameraToggle == 1)
            {
                cameraToggle = 0;
                CameraButtonText.text = "Rotate";
                Camera.main.fieldOfView = 80f;
                //Camera.main.transform.position = myGameObj.transform.position + new Vector3(2, 4, 4);
                //Camera.main.transform.position = new Vector3(-4.87f, 0.23f, -4.17f);
                transform.LookAt(myGameObj.transform.position);
            }
        }
    }
}
