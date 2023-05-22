using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMechanicFrog : MonoBehaviour
{
    LotCount lotScript;
    public GameObject Lots;

    public GameObject worm;

    public TMP_Text frogLevel;
    public TMP_Text frogRequirement;
    public GameObject waterlilies;
    public GameObject frogStation;
    public GameObject FrogWater;

    public GameObject AppleFly;

    public GameObject goose;
    public GameObject goosePlot;

    public GameObject Bee;
    public GameObject BeeLot;

    private void Awake()
    {
        lotScript = Lots.GetComponent<LotCount>();
    }

    public void BuildFrog()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && FrogWater.activeSelf && frogLevel.text == "Level 0")
        {
            frogLevel.text = "Level 1";
            frogRequirement.text = "0 resources to build idle station";

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !frogStation.activeSelf && frogLevel.text == "Level 1")
        {
            frogStation.SetActive(true);
            goose.SetActive(true);
            goosePlot.SetActive(true);

            lotScript.lotsCount += 1;
            frogLevel.text = "Level 2";
            frogRequirement.text = "Water Lilies + apple";

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && AppleFly.activeSelf && !waterlilies.activeSelf && frogLevel.text == "Level 2")
        {
            waterlilies.SetActive(true);

            if (!Bee.activeSelf)
            {
                Bee.SetActive(true);
                BeeLot.SetActive(true);
            }

            frogLevel.text = "Level 3";
            frogRequirement.text = "Maximum Level Reached";
        }
    }
}
