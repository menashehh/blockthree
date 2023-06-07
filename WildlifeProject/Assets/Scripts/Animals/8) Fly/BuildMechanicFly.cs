using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMechanicFly : MonoBehaviour
{
    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    public TMP_Text flyLevel;
    public TMP_Text flyRequirement;

    public GameObject worm;

    public GameObject FlyReq;
    public GameObject FlyStation;
    public GameObject FlyGrass;
    public GameObject FlyHex;
    public GameObject FlyHex2;

    public AudioSource Locked;
    public AudioSource MaximumLevel;

    private void Awake()
    {
        resourceCountScript = resourceCountObject.GetComponent<ResourceCount>();
    }

    private void Update()
    {
        if (!FlyReq.activeSelf && flyLevel.text == "Level 0")
        {
            FlyHex.SetActive(true);
        }
    }

    public void BuildFly()
    {
        if (resourceCountScript.resources >= 0 && FlyReq.activeSelf && flyLevel.text == "Level 0")
        {
            flyLevel.text = "Level 1";
            flyRequirement.text = "2230 Resources to build idle station";

            Destroy(GameObject.Find("Fly").GetComponent<FlyInteraction>().text2);
            GameObject.Find("Fly").GetComponent<FlyInteraction>().levelPrefabLimit = 0;

            return;
        }

        if (resourceCountScript.resources >= 2230 && !FlyStation.activeSelf && flyLevel.text == "Level 1")
        {
            resourceCountScript.resources -= 2230;

            FlyStation.SetActive(true);
            FlyHex2.SetActive(true);

            flyLevel.text = "Level 2";
            flyRequirement.text = "Grass";

            Destroy(GameObject.Find("Fly").GetComponent<FlyInteraction>().text2);
            GameObject.Find("Fly").GetComponent<FlyInteraction>().levelPrefabLimit = 0;

            return;
        }

        if (resourceCountScript.resources >= 0 && FlyGrass.activeSelf && flyLevel.text == "Level 2")
        {
            MaximumLevel.Play();

            flyLevel.text = "Level 3";
            flyRequirement.text = "Maximum Level Reached";

            Destroy(GameObject.Find("Fly").GetComponent<FlyInteraction>().text2);
            GameObject.Find("Fly").GetComponent<FlyInteraction>().levelPrefabLimit = 0;

            return;
        }

        Locked.Play();
    }
}
