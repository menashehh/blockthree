using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ResourceUpdate2 : MonoBehaviour
{
    // Secondary resource update script that is used for the worm and wolf

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
            if (this.name == "Worm") refScript.AddResourceWorm();

            if (this.name == "Wolf") refScript.AddResourceWolf();
        }
    }
}
