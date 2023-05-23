using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMechanicBeaver : MonoBehaviour
{
    public TMP_Text beaverLevel;
    public TMP_Text beaverRequirement;
    public GameObject BeaverStation;

    public GameObject worm;

    public GameObject FrogWater;

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

            beaverLevel.text = "Level 2";
            beaverRequirement.text = "Maximum Level Reached";
        }
    }
}
