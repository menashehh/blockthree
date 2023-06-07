using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WormHexBuild : MonoBehaviour
{
    LotCount lotScript;

    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    public GameObject Lots;
    public Material DirtMaterial;
    public AudioSource Locked;
    public AudioSource AnimalUnlock;

    public TMP_Text wormLevel;
    public GameObject worm;
    public GameObject waterWorm;
    public GameObject treeWorm;
    public GameObject grass1Worm;
    public GameObject grass2Worm;
    public GameObject WormHex;
    public GameObject WormHex2;
    public GameObject WormHex3;
    public GameObject WormHex4;

    public GameObject frog;
    public GameObject frogPlot;
    // public GameObject frogPlotTrees;


    private void Awake()
    {
        lotScript = Lots.GetComponent<LotCount>();
        resourceCountScript = resourceCountObject.GetComponent<ResourceCount>();
    }

    public void BuildHexWorm()
    {
        if (resourceCountScript.resources >= 0 && !grass1Worm.activeSelf && wormLevel.text == "Level 0")
        {
            grass1Worm.SetActive(true);

            frog.SetActive(true);
            frogPlot.SetActive(true);
            // frogPlotTrees.SetActive(true);

            GameObject.Find("HexBuildWorm").SetActive(false);

            GameObject.Find("Hex Button Worm").SetActive(false);

            AnimalUnlock.Play();

            lotScript.lotsCount += 1;

            return;
        }

        if (resourceCountScript.resources >= 30 && !waterWorm.activeSelf && wormLevel.text == "Level 2")
        {
            resourceCountScript.resources -= 30;

            waterWorm.SetActive(true);

            GameObject.Find("HexBuildWorm2").SetActive(false);

            GameObject.Find("Hex Button Worm 2").SetActive(false);

            return;
        }

        if (resourceCountScript.resources >= 185 && !treeWorm.activeSelf && wormLevel.text == "Level 4")
        {
            resourceCountScript.resources -= 185;

            treeWorm.SetActive(true);

            GameObject.Find("HexBuildWorm3").SetActive(false);

            GameObject.Find("Hex Button Worm 3").SetActive(false);

            return;
        }

        if (resourceCountScript.resources >= 12750 && !grass2Worm.activeSelf && wormLevel.text == "Level 6")
        {
            resourceCountScript.resources -= 12750;

            grass2Worm.SetActive(true);

            GameObject.Find("HexBuildWorm4").SetActive(false);

            GameObject.Find("Hex Button Worm 4").SetActive(false);

            return;
        }

        Locked.Play();
    }
}
