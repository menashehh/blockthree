using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ResourceUpdate2 : MonoBehaviour
{
    // Secondary resource update script that is used for the rest of animals

    ResourceUpdate refScript;
    public GameObject station;

    void Awake()
    {
        refScript = station.GetComponent<ResourceUpdate>();
    }

    private void OnMouseDown()
    {
        if (Camera.main.fieldOfView == 80f && !GameObject.Find("Background"))
        {
            if (this.name == "Frog") refScript.AddResourceFrog();

            if (this.name == "Goose") refScript.AddResourceGoose();

            if (this.name == "Wolf") refScript.AddResourceWolf();

            if (this.name == "Sparrow") refScript.AddResourceSparrow();

            if (this.name == "Buzzard") refScript.AddResourceBuzzard();

            if (this.name == "Beaver") refScript.AddResourceBeaver();

            if (this.name == "Fly") refScript.AddResourceFly();

            if (this.name == "Bee") refScript.AddResourceBee();
        }
    }
}
