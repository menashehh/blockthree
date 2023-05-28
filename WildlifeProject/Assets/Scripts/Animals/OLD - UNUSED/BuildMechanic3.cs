using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMechanic3 : MonoBehaviour
{
    // Build mechanic for the buttons and gameplay loop (FLY - BEE BRANCH)

    WormInteraction wormInteractionScript;
    FlyInteraction flyInteractionScript;
    BeeInteraction beeInteractionScript;

    CameraMechanicsRework cameraScript;
    LotCount lotScript;

    public Camera cam;
    public GameObject Lots;

    public GameObject worm;

    public GameObject fly;
    public GameObject flyReq;
    public GameObject flyStation;

    public GameObject bee;
    public GameObject beeReq;
    public GameObject beeStation;
    public GameObject secondPlotD;

    private void Awake()
    {
        cameraScript = cam.GetComponent<CameraMechanicsRework>();
        lotScript = Lots.GetComponent<LotCount>();

        wormInteractionScript = worm.GetComponent<WormInteraction>();
        flyInteractionScript = fly.GetComponent<FlyInteraction>();
        beeInteractionScript = bee.GetComponent<BeeInteraction>();
    }

    public void BuildFly()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 900 && !flyReq.activeSelf)
        {
            worm.GetComponent<ResourceUpdate>().resources -= 900;

            flyReq.SetActive(true);
            flyStation.SetActive(true);

            bee.SetActive(true);
            secondPlotD.SetActive(true);

            flyInteractionScript.npcName = false;
            flyInteractionScript.flyText.SetActive(false);

            lotScript.lotsCount += 1;
        }
    }

    public void BuildBee() 
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 1200 && !beeReq.activeSelf)
        {
            worm.GetComponent<ResourceUpdate>().resources -= 1200;

            beeReq.SetActive(true);
            beeStation.SetActive(true);

            beeInteractionScript.npcName = false;
            beeInteractionScript.beeText.SetActive(false);
        }
    }
}
