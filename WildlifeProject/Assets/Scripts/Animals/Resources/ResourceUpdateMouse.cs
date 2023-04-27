using System.Collections;
using System.Collections.Generic;
using System.Resources;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class ResourceUpdateMouse : MonoBehaviour
{
    // Resource timer update script that is used for the idle stations

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
            if (GameObject.Find("Apple Tree") && !GameObject.Find("Wolf House"))
            {
                refScript.resources += 3;
                if (refScript.FloatingTextPrefab != null) refScript.ShowFloatingText1();
                if (refScript.FloatingTextPrefab != null) refScript.ShowFloatingText2();
            }
            else if (GameObject.Find("Apple Tree") && GameObject.Find("Wolf House"))
            {
                refScript.resources += 7;
                if (refScript.FloatingTextPrefab != null) refScript.ShowFloatingText1();
                if (refScript.FloatingTextPrefab != null) refScript.ShowFloatingText2();
                if (refScript.FloatingTextPrefab != null) refScript.ShowFloatingText4();
            }
            else
            {
                refScript.resources++;
                if (refScript.FloatingTextPrefab != null) refScript.ShowFloatingText1();
            }
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
            if (this.name == "Flower") refScript.AddResourceFlower();

            if (this.name == "Apple Tree") refScript.AddResourceAppleTree();

            if (this.name == "Wolf House") refScript.AddResourceWolfHouse();
        }
    }
}
