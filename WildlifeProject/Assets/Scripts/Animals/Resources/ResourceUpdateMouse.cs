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

    void Awake()
    {
        refScript = station.GetComponent<ResourceUpdate>();
    }

    private void Update()
    {
        refScript.Timer += Time.deltaTime;

        if (refScript.Timer >= refScript.DelayAmount)
        {
            if (GameObject.Find("Apple Tree"))
            {
                refScript.resources += 1;
                if (refScript.FloatingTextPrefab != null) refScript.ShowFloatingText1();
            }

            if (GameObject.Find("Flower"))
            {
                refScript.resources += 2;
                if (refScript.FloatingTextPrefab != null) refScript.ShowFloatingText2();
            }

            if (GameObject.Find("Goose Station"))
            {
                refScript.resources += 4;
                if (refScript.FloatingTextPrefab != null) refScript.ShowFloatingText4();
            }

            if (GameObject.Find("Wolf House"))
            {
                refScript.resources += 8;
                if (refScript.FloatingTextPrefab != null) refScript.ShowFloatingText8();
            }

            if (GameObject.Find("Sparrow Station"))
            {
                refScript.resources += 3;
                if (refScript.FloatingTextPrefab != null) refScript.ShowFloatingText3();
            }

            if (GameObject.Find("Buzzard Station"))
            {
                refScript.resources += 5;
                if (refScript.FloatingTextPrefab != null) refScript.ShowFloatingText5();
            }

            if (GameObject.Find("Beaver Station"))
            {
                refScript.resources += 7;
                if (refScript.FloatingTextPrefab != null) refScript.ShowFloatingText7();
            }

            if (GameObject.Find("Fly Station"))
            {
                refScript.resources += 9;
                if (refScript.FloatingTextPrefab != null) refScript.ShowFloatingText9();
            }

            if (GameObject.Find("Bee Station"))
            {
                refScript.resources += 11;
                if (refScript.FloatingTextPrefab != null) refScript.ShowFloatingText11();
            }

            refScript.Timer = 0f;
        }
        refScript.resourceText.text = "" + refScript.resources;
    }

    private void OnMouseDown()
    {
        if (Camera.main.fieldOfView == 80f && !GameObject.Find("Background"))
        {
            if (this.name == "Apple Tree") refScript.AddResourceAppleTree();

            if (this.name == "Flower") refScript.AddResourceFlower();

            if (this.name == "Goose Station") refScript.AddResourceGooseS();

            if (this.name == "Wolf House") refScript.AddResourceWolfHouse();

            if (this.name == "Sparrow Station") refScript.AddResourceSparrowS();

            if (this.name == "Buzzard Station") refScript.AddResourceBuzzardS();

            if (this.name == "Beaver Station") refScript.AddResourceBeaverS();

            if (this.name == "Fly Station") refScript.AddResourceFlyS();

            if (this.name == "Bee Station") refScript.AddResourceBeeS();
        }
    }
}
