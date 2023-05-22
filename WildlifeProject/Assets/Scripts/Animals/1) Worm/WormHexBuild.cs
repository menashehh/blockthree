using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormHexBuild : MonoBehaviour
{
    LotCount lotScript;

    public GameObject Lots;
    public Material DirtMaterial;

    public GameObject worm;
    public GameObject apple;
    public GameObject WormHex;

    public GameObject frog;
    public GameObject frogPlot;
    public GameObject frogPlotTrees;


    private void Awake()
    {
        lotScript = Lots.GetComponent<LotCount>();
    }

    public void BuildHexWorm()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !apple.activeSelf)
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
    }
}
