using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMechanicWorm : MonoBehaviour
{
    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    LotCount lotScript;
    public GameObject Lots;
    public AudioSource Locked;
    public AudioSource AnimalUnlock;
    public AudioSource MaximumLevel;

    public TMP_Text wormLevel;
    public TMP_Text wormRequirement;
    public GameObject wormHex;
    public GameObject wormHex2;
    public GameObject wormHex3;
    public GameObject wormHex4;
    public GameObject worm;
    public GameObject waterWorm;
    public GameObject treeWorm;
    public GameObject grass1Worm;
    public GameObject grass2Worm;
    public GameObject buttercup;
    public GameObject wormStation;

    public GameObject AppleFly;

    public GameObject FrogWater;
    public GameObject frogHex;

    public GameObject sparrow;
    public GameObject sparrowPlot;

    public GameObject Bee;
    public GameObject BeeLot;

    private void Awake()
    {
        lotScript = Lots.GetComponent<LotCount>();
        resourceCountScript = resourceCountObject.GetComponent<ResourceCount>();
    }

    private void Update()
    {
        if (!grass1Worm.activeSelf && wormLevel.text == "Level 0")
        {
            wormHex.SetActive(true);
        }

        if (!FrogWater.activeSelf && wormLevel.text == "Level 3")
        {
            frogHex.SetActive(true);
        }
    }

    public void BuildWorm()
    {
        if (resourceCountScript.resources >= 0 && grass1Worm.activeSelf && wormLevel.text == "Level 0")
        {
            wormLevel.text = "Level 1";
            wormRequirement.text = "Build idle station (Free)";

            Destroy(GameObject.Find("Worm").GetComponent<WormInteraction>().text2);
            GameObject.Find("Worm").GetComponent<WormInteraction>().levelPrefabLimit = 0;

            return;
        }

        if (resourceCountScript.resources >= 0 && !wormStation.activeSelf && wormLevel.text == "Level 1")
        {
            wormStation.SetActive(true);
            sparrow.SetActive(true);
            sparrowPlot.SetActive(true);

            wormHex2.SetActive(true);

            AnimalUnlock.Play();

            lotScript.lotsCount += 1;
            wormLevel.text = "Level 2";
            wormRequirement.text = "Water";

            Destroy(GameObject.Find("Worm").GetComponent<WormInteraction>().text2);
            GameObject.Find("Worm").GetComponent<WormInteraction>().levelPrefabLimit = 0;

            return;
        }

        if (resourceCountScript.resources >= 0 && waterWorm.activeSelf && wormLevel.text == "Level 2")
        {
            wormLevel.text = "Level 3";
            wormRequirement.text = "Water (Frog) + 105 Resources";

            Destroy(GameObject.Find("Worm").GetComponent<WormInteraction>().text2);
            GameObject.Find("Worm").GetComponent<WormInteraction>().levelPrefabLimit = 0;

            return;
        }

        if (resourceCountScript.resources >= 105 && FrogWater.activeSelf && wormLevel.text == "Level 3")
        {
            resourceCountScript.resources -= 105;

            wormLevel.text = "Level 4";
            wormRequirement.text = "Tree";

            wormHex3.SetActive(true);

            Destroy(GameObject.Find("Worm").GetComponent<WormInteraction>().text2);
            GameObject.Find("Worm").GetComponent<WormInteraction>().levelPrefabLimit = 0;

            return;
        }

        if (resourceCountScript.resources >= 0 && treeWorm.activeSelf && wormLevel.text == "Level 4")
        {
            wormLevel.text = "Level 5";
            wormRequirement.text = "Buttercup + apple + 2460 Resources";

            Destroy(GameObject.Find("Worm").GetComponent<WormInteraction>().text2);
            GameObject.Find("Worm").GetComponent<WormInteraction>().levelPrefabLimit = 0;

            return;
        }

        if (resourceCountScript.resources >= 2460 && AppleFly.activeSelf && !buttercup.activeSelf && wormLevel.text == "Level 5")
        {
            resourceCountScript.resources -= 2460;

            buttercup.SetActive(true);

            if (!Bee.activeSelf)
            {
                Bee.SetActive(true);
                BeeLot.SetActive(true);

                AnimalUnlock.Play();

                lotScript.lotsCount += 1;
            }

            wormHex4.SetActive(true);

            wormLevel.text = "Level 6";
            wormRequirement.text = "Grass";

            Destroy(GameObject.Find("Worm").GetComponent<WormInteraction>().text2);
            GameObject.Find("Worm").GetComponent<WormInteraction>().levelPrefabLimit = 0;

            return;
        }

        if (resourceCountScript.resources >= 0 && grass2Worm.activeSelf && wormLevel.text == "Level 6")
        {
            MaximumLevel.Play();

            wormLevel.text = "Level 7";
            wormRequirement.text = "Maximum Level Reached";

            Destroy(GameObject.Find("Worm").GetComponent<WormInteraction>().text2);
            GameObject.Find("Worm").GetComponent<WormInteraction>().levelPrefabLimit = 0;

            return;
        }

        Locked.Play();
    }
}
