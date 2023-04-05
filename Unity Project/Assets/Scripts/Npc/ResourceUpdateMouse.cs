using System.Collections;
using System.Collections.Generic;
using System.Resources;
using System.Runtime.InteropServices;
using TMPro;
using UnityEditor.Animations;
using UnityEngine;

public class ResourceUpdateMouse : MonoBehaviour
{
    ResourceUpdate refScript;
    public GameObject station;
    public GameObject instance;

    void Awake()
    {
        refScript = station.GetComponent<ResourceUpdate>();

        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        refScript.Timer += Time.deltaTime;

        if (refScript.Timer >= refScript.DelayAmount)
        {
            refScript.Timer = 0f;
            refScript.resources++;
        }
        refScript.resourceText.text = "" + refScript.resources;

        if (instance.activeSelf)
        {
            refScript.stationActive = true;
        }
    }

    private void OnMouseDown()
    {
        if (Camera.main.fieldOfView == 40f)
        {
            refScript.AddResource();
        }
    }
}
