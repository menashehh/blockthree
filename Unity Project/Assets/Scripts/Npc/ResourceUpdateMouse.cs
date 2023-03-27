using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Animations;
using UnityEngine;

public class ResourceUpdateMouse : MonoBehaviour
{
    ResourceUpdate refScript;
    public GameObject station;

    void Awake()
    {
        refScript = station.GetComponent<ResourceUpdate>();
    }

    private void OnMouseDown()
    {
        if (Camera.main.fieldOfView == 40f)
        {
            refScript.AddResource();
        }
    }
}
