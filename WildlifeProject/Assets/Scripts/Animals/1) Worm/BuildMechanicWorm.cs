using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMechanicWorm : MonoBehaviour
{
    LotCount lotScript;
    public GameObject Lots;
    public AudioSource Locked;

    public TMP_Text wormLevel;
    public TMP_Text wormRequirement;
    public GameObject wormHex2;
    public GameObject wormHex3;
    public GameObject wormHex4;
    public GameObject worm;
    public GameObject waterWorm;
    public GameObject treeWorm;
    public GameObject grass2Worm;
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

            wormHex2.SetActive(true);

            lotScript.lotsCount += 1;
            wormLevel.text = "Level 2";
            wormRequirement.text = "Water";

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && waterWorm.activeSelf && wormLevel.text == "Level 2")
        {
            wormLevel.text = "Level 3";
            wormRequirement.text = "Water (Frog)";

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && FrogWater.activeSelf && wormLevel.text == "Level 3")
        {
            wormLevel.text = "Level 4";
            wormRequirement.text = "Tree";

            wormHex3.SetActive(true);
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && treeWorm.activeSelf && wormLevel.text == "Level 4")
        {
            wormLevel.text = "Level 5";
            wormRequirement.text = "Buttercup + apple";

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && AppleFly.activeSelf && !buttercup.activeSelf && wormLevel.text == "Level 5")
        {
            buttercup.SetActive(true);

            if (!Bee.activeSelf)
            {
                Bee.SetActive(true);
                BeeLot.SetActive(true);

                lotScript.lotsCount += 1;
            }

            wormHex4.SetActive(true);

            wormLevel.text = "Level 6";
            wormRequirement.text = "Grass";

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && grass2Worm.activeSelf && wormLevel.text == "Level 6")
        {
            wormLevel.text = "Level 7";
            wormRequirement.text = "Maximum Level Reached";

            return;
        }

        Locked.Play();
    }
}
