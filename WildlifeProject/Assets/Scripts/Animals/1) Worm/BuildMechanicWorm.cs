using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMechanicWorm : MonoBehaviour
{
    LotCount lotScript;
    public GameObject Lots;

    public TMP_Text wormLevel;
    public TMP_Text wormRequirement;
    public GameObject worm;
    public GameObject buttercup;
    public GameObject apple;
    public GameObject appleTreeStation;

    public GameObject AppleFly;

    public GameObject FrogWater;

    public GameObject sparrow;
    public GameObject sparrowPlot;

    public GameObject Bee;
    public GameObject BeeLot;

    private void Awake()
    {
        lotScript = Lots.GetComponent<LotCount>();
    }

    public void BuildWorm()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && apple.activeSelf && wormLevel.text == "Level 0")
        {   
            wormLevel.text = "Level 1";
            wormRequirement.text = "0 resources to build idle station";

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !appleTreeStation.activeSelf && wormLevel.text == "Level 1")
        {
            appleTreeStation.SetActive(true);
            sparrow.SetActive(true);
            sparrowPlot.SetActive(true);

            lotScript.lotsCount += 1;
            wormLevel.text = "Level 2";
            wormRequirement.text = "Water (frog)";

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && FrogWater.activeSelf && wormLevel.text == "Level 2")
        {
            wormLevel.text = "Level 3";
            wormRequirement.text = "Buttercup + apple";
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && AppleFly.activeSelf && !buttercup.activeSelf && wormLevel.text == "Level 3")
        {
            buttercup.SetActive(true);

            if (!Bee.activeSelf)
            {
                Bee.SetActive(true);
                BeeLot.SetActive(true);
            }

            wormLevel.text = "Level 4";
            wormRequirement.text = "Maximum Level Reached";
        }
    }
}
