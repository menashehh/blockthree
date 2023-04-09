using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour
{
    public Camera cameraObj;
    public GameObject myGameObj;
    public GameObject myGameObj2;
    public GameObject myGameObj3;
    public float speed = 2f;

    private void Awake()
    {
        //transform.LookAt(myGameObj.transform.position);
        cameraObj.transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    void Update()
    {
        transform.LookAt(myGameObj.transform.position);

        RotateCamera();
    }

    void RotateCamera()
    {
        if (Input.GetMouseButton(0))
        {
            cameraObj.transform.RotateAround(myGameObj.transform.position, cameraObj.transform.up, -Input.GetAxis("Mouse X") * speed);
            // cameraObj.transform.RotateAround(myGameObj.transform.position, cameraObj.transform.right, -Input.GetAxis("Mouse Y") * speed);
        }
    }
}
