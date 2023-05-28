using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMechanicSparrow : MonoBehaviour
{
    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    LotCount lotScript;
    public GameObject Lots;
    public AudioSource Locked;
    public AudioSource AnimalUnlock;
    public AudioSource MaximumLevel;

    public GameObject worm;
    public TMP_Text wormLevel;

    public TMP_Text sparrowLevel;
    public TMP_Text sparrowRequirement;
    public GameObject sparrowStation;
    public GameObject sparrowWater;
    public GameObject sparrowGrass;
    public GameObject SparrowHex;
    public GameObject SparrowHex2;

    public GameObject buzzard;
    public GameObject buzzardPlot;
    public GameObject buzzardReq;

    private void Awake()
    {
        lotScript = Lots.GetComponent<LotCount>();
        resourceCountScript = resourceCountObject.GetComponent<ResourceCount>();
    }

    public void BuildSparrow()
    {
        if (resourceCountScript.resources >= 0 && !sparrowStation.activeSelf && (wormLevel.text == "Level 3" || wormLevel.text == "Level 4" || wormLevel.text == "Level 5" || wormLevel.text == "Level 6" || wormLevel.text == "Level 7"))
        {
            sparrowStation.SetActive(true);
            SparrowHex.SetActive(true);

            buzzard.SetActive(true);
            buzzardPlot.SetActive(true);

            AnimalUnlock.Play();

            lotScript.lotsCount += 1;

            sparrowLevel.text = "Level 1";
            sparrowRequirement.text = "Water";

            return;
        }

        if (resourceCountScript.resources >= 0 && sparrowWater.activeSelf && sparrowLevel.text == "Level 1")
        {
            sparrowLevel.text = "Level 2";
            sparrowRequirement.text = "Tree (buzzard)";
        }

        if (resourceCountScript.resources >= 0 && buzzardReq.activeSelf && sparrowLevel.text == "Level 2")
        {
            SparrowHex2.SetActive(true);

            sparrowLevel.text = "Level 3";
            sparrowRequirement.text = "Grass";

            return;
        }

        if (resourceCountScript.resources >= 0 && sparrowGrass.activeSelf && sparrowLevel.text == "Level 3")
        {
            MaximumLevel.Play();

            sparrowLevel.text = "Level 4";
            sparrowRequirement.text = "Maximum Level Reached";

            return;
        }

        Locked.Play();
    }
}
