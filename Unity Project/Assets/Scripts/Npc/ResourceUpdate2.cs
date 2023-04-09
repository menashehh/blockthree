using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ResourceUpdate2 : MonoBehaviour
{
    ResourceUpdate refScript;
    public GameObject station;

    void Awake()
    {
        refScript = station.GetComponent<ResourceUpdate>();

        DontDestroyOnLoad(this.gameObject);
    }

    private void OnMouseDown()
    {
        if (Camera.main.fieldOfView == 40f)
        {
            refScript.AddResource();
        }
    }
}
