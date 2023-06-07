using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMechanicBeaver : MonoBehaviour
{
    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    public TMP_Text beaverLevel;
    public TMP_Text beaverRequirement;
    public GameObject BeaverStation;
    public GameObject BeaverTree;
    public GameObject BeaverHex;

    public GameObject worm;

    public GameObject FrogWater;

    public AudioSource Locked;
    public AudioSource MaximumLevel;

    private void Awake()
    {
        resourceCountScript = resourceCountObject.GetComponent<ResourceCount>();
    }

    public void BuildBeaver()
    {
        if (resourceCountScript.resources >= 450 && FrogWater.activeSelf && beaverLevel.text == "Level 0")
        {
            resourceCountScript.resources -= 450;

            beaverLevel.text = "Level 1";
            beaverRequirement.text = "2230 Resources to build idle station";

            Destroy(GameObject.Find("Beaver").GetComponent<BeaverInteraction>().text2);
            GameObject.Find("Beaver").GetComponent<BeaverInteraction>().levelPrefabLimit = 0;

            return;
        }

        if (resourceCountScript.resources >= 2230 && !BeaverStation.activeSelf && beaverLevel.text == "Level 1")
        {
            resourceCountScript.resources -= 2230;

            BeaverStation.SetActive(true);
            BeaverHex.SetActive(true);

            beaverLevel.text = "Level 2";  
            beaverRequirement.text = "Tree";

            Destroy(GameObject.Find("Beaver").GetComponent<BeaverInteraction>().text2);
            GameObject.Find("Beaver").GetComponent<BeaverInteraction>().levelPrefabLimit = 0;

            return;
        }

        if (resourceCountScript.resources >= 0 && BeaverTree.activeSelf && beaverLevel.text == "Level 2")
        {
            MaximumLevel.Play();

            beaverLevel.text = "Level 3";
            beaverRequirement.text = "Maximum Level Reached";

            Destroy(GameObject.Find("Beaver").GetComponent<BeaverInteraction>().text2);
            GameObject.Find("Beaver").GetComponent<BeaverInteraction>().levelPrefabLimit = 0;

            return;
        }

        Locked.Play();
    }
}
