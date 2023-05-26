using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMechanicBeaver : MonoBehaviour
{
    public TMP_Text beaverLevel;
    public TMP_Text beaverRequirement;
    public GameObject BeaverStation;
    public GameObject BeaverTree;
    public GameObject BeaverHex;

    public GameObject worm;

    public GameObject FrogWater;

    public AudioSource Locked;

    public void BuildBeaver()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && FrogWater.activeSelf && beaverLevel.text == "Level 0")
        {
            beaverLevel.text = "Level 1";
            beaverRequirement.text = "0 resources to build idle station";

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !BeaverStation.activeSelf && beaverLevel.text == "Level 1")
        {
            BeaverStation.SetActive(true);
            BeaverHex.SetActive(true);

            beaverLevel.text = "Level 2";
            beaverRequirement.text = "Tree";

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && BeaverTree.activeSelf && beaverLevel.text == "Level 2")
        {
            beaverLevel.text = "Level 3";
            beaverRequirement.text = "Maximum Level Reached";

            return;
        }

        Locked.Play();
    }
}
