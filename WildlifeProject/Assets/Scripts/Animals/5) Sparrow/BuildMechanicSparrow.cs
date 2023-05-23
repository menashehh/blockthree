using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMechanicSparrow : MonoBehaviour
{
    LotCount lotScript;
    public GameObject Lots;

    public GameObject worm;
    public TMP_Text wormLevel;

    public TMP_Text sparrowLevel;
    public TMP_Text sparrowRequirement;
    public GameObject sparrowStation;

    public GameObject buzzard;
    public GameObject buzzardPlot;
    public GameObject buzzardReq;

    private void Awake()
    {
        lotScript = Lots.GetComponent<LotCount>();
    }

    public void BuildSparrow()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !sparrowStation.activeSelf && wormLevel.text == "Level 3")
        {
            sparrowStation.SetActive(true);

            buzzard.SetActive(true);
            buzzardPlot.SetActive(true);

            lotScript.lotsCount += 1;

            sparrowLevel.text = "Level 1";
            sparrowRequirement.text = "Tree (buzzard)";

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && buzzardReq.activeSelf && sparrowLevel.text == "Level 1")
        {
            sparrowLevel.text = "Level 2";
            sparrowRequirement.text = "Maximum Level Reached";
        }
    }
}
