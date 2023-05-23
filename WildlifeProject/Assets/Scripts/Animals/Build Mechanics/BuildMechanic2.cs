using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMechanic2 : MonoBehaviour
{
    // Build mechanic for the buttons and gameplay loop (SPARROW - BUZZARD - BEAVER BRANCH)

    WormInteraction wormInteractionScript;
    SparrowInteraction sparrowInteractionScript;
    BuzzardInteraction buzzardInteractionScript;
    BeaverInteraction beaverInteractionScript;
    FlyInteraction flyInteractionScript;

    CameraMechanicsRework cameraScript;
    LotCount lotScript;

    public Camera cam;
    public GameObject Lots;

    public GameObject worm;

    public GameObject sparrow;
    public GameObject sparrowReq;
    public GameObject sparrowStation;

    public GameObject buzzard;
    public GameObject buzzardReq;
    public GameObject buzzardStation;
    public GameObject secondPlotB;

    public GameObject beaver;
    public GameObject beaverReq;
    public GameObject beaverStation;
    public GameObject firstPlotC;

    public GameObject fly;
    public GameObject firstPlotD;

    private void Awake()
    {
        cameraScript = cam.GetComponent<CameraMechanicsRework>();
        lotScript = Lots.GetComponent<LotCount>();

        wormInteractionScript = worm.GetComponent<WormInteraction>();
        sparrowInteractionScript = sparrow.GetComponent<SparrowInteraction>();
        buzzardInteractionScript = buzzard.GetComponent<BuzzardInteraction>();
        beaverInteractionScript = beaver.GetComponent<BeaverInteraction>();
        flyInteractionScript = fly.GetComponent<FlyInteraction>();
    }

    public void BuildSparrow()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 200 && !sparrowReq.activeSelf)
        {
            worm.GetComponent<ResourceUpdate>().resources -= 200;

            sparrowReq.SetActive(true);
            sparrowStation.SetActive(true);

            buzzard.SetActive(true);
            secondPlotB.SetActive(true);

            sparrowInteractionScript.npcName = false;
            sparrowInteractionScript.sparrowText.SetActive(false);

            lotScript.lotsCount += 1;
        }
    }

    public void BuildBuzzard()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 400 && !buzzardReq.activeSelf)
        {
            worm.GetComponent<ResourceUpdate>().resources -= 400;

            buzzardReq.SetActive(true);
            buzzardStation.SetActive(true);

            beaver.SetActive(true);
            firstPlotC.SetActive(true);

            fly.SetActive(true);
            firstPlotD.SetActive(true);

            buzzardInteractionScript.npcName = false;
            buzzardInteractionScript.buzzardText.SetActive(false);

            lotScript.lotsCount += 2;
        }
    }

    public void BuildBeaver() 
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 500 && !beaverReq.activeSelf)
        {
            worm.GetComponent<ResourceUpdate>().resources -= 500;

            beaverReq.SetActive(true);
            beaverStation.SetActive(true);

            beaverInteractionScript.npcName = false;
            beaverInteractionScript.beaverText.SetActive(false);
        }
    }
}
