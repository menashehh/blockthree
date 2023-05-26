using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WormHexBuild : MonoBehaviour
{
    LotCount lotScript;

    public GameObject Lots;
    public Material DirtMaterial;
    public AudioSource Locked;

    public TMP_Text wormLevel;
    public GameObject worm;
    public GameObject waterWorm;
    public GameObject treeWorm;
    public GameObject grass2Worm;
    public GameObject apple;
    public GameObject WormHex;
    public GameObject WormHex2;
    public GameObject WormHex3;
    public GameObject WormHex4;

    public GameObject frog;
    public GameObject frogPlot;
    public GameObject frogPlotTrees;


    private void Awake()
    {
        lotScript = Lots.GetComponent<LotCount>();
    }

    public void BuildHexWorm()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !apple.activeSelf && wormLevel.text == "Level 0")
        {
            apple.SetActive(true);

            frog.SetActive(true);
            frogPlot.SetActive(true);
            frogPlotTrees.SetActive(true);

            WormHex.GetComponent<MeshRenderer>().material = DirtMaterial;

            lotScript.lotsCount += 1;

            GameObject.Find("HexBuildWorm").GetComponent<WormHex>().menuOpen = 0;

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !waterWorm.activeSelf && wormLevel.text == "Level 2")
        {
            waterWorm.SetActive(true);

            WormHex2.GetComponent<MeshRenderer>().material = DirtMaterial;

            GameObject.Find("HexBuildWorm2").GetComponent<WormHex2>().menuOpen = 0;

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !treeWorm.activeSelf && wormLevel.text == "Level 4")
        {
            treeWorm.SetActive(true);

            WormHex3.GetComponent<MeshRenderer>().material = DirtMaterial;

            GameObject.Find("HexBuildWorm3").GetComponent<WormHex3>().menuOpen = 0;

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !grass2Worm.activeSelf && wormLevel.text == "Level 6")
        {
            grass2Worm.SetActive(true);

            WormHex4.GetComponent<MeshRenderer>().material = DirtMaterial;

            GameObject.Find("HexBuildWorm4").GetComponent<WormHex4>().menuOpen = 0;

            return;
        }

        Locked.Play();
    }
}
