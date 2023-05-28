using System.Collections;
using System.Collections.Generic;
using System.Resources;
using TMPro;
using UnityEngine;

public class BuildMechanic : MonoBehaviour
{
    // Build mechanic for the buttons and gameplay loop (WORM - FROG - GOOSE - WOLF BRANCH)

    WormInteraction wormInteractionScript;
    FrogInteraction frogInteractionScript;
    GooseInteraction gooseInteractionScript;
    WolfInteraction wolfInteractionScript;
    SparrowInteraction sparrowInteractionScript;

    CameraMechanicsRework cameraScript;
    LotCount lotScript;

    public Camera cam;
    public GameObject Lots;

    public GameObject worm;
    public GameObject apple;
    public GameObject appleTreeStation;

    public GameObject frog;
    public GameObject cloud;
    public GameObject flowerStation;
    public GameObject secondPlot;
    public GameObject secondPlotTrees;

    public GameObject goose;
    public GameObject gooseReq;
    public GameObject gooseStation;
    public GameObject thirdPlot;
    //public GameObject thirdPlotTrees;

    public GameObject wolf;
    public GameObject bone;
    public GameObject wolfHouseStation;
    public GameObject fourthPlot;
    public GameObject fourthPlotTrees;

    public GameObject sparrow;
    public GameObject firstPlotB;

    void Awake()
    {
        cameraScript = cam.GetComponent<CameraMechanicsRework>();
        lotScript = Lots.GetComponent<LotCount>();

        wormInteractionScript = worm.GetComponent<WormInteraction>();
        frogInteractionScript = frog.GetComponent<FrogInteraction>();
        gooseInteractionScript = goose.GetComponent<GooseInteraction>();
        wolfInteractionScript = wolf.GetComponent<WolfInteraction>();
        sparrowInteractionScript = sparrow.GetComponent<SparrowInteraction>();
    }

    public void BuildWorm()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 50 && !apple.activeSelf)
        {
            worm.GetComponent<ResourceUpdate>().resources -= 50;

            apple.SetActive(true);
            appleTreeStation.SetActive(true);

            frog.SetActive(true);
            secondPlot.SetActive(true);
            secondPlotTrees.SetActive(true);

            sparrow.SetActive(true);
            firstPlotB.SetActive(true);

            //cam.transform.rotation = Quaternion.Euler(0, 0, 0);
            //cameraScript.myGameObj = GameObject.Find("Frog");
            //cam.fieldOfView = 60f;

            wormInteractionScript.npcName = false;
            wormInteractionScript.wormText.SetActive(false);

            lotScript.lotsCount += 2;
        }
    }

    public void BuildFrog()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 100 && !cloud.activeSelf)
        {
            worm.GetComponent<ResourceUpdate>().resources -= 100;

            cloud.SetActive(true);
            flowerStation.SetActive(true);

            goose.SetActive(true);
            thirdPlot.SetActive(true);
            // thirdPlotTrees.SetActive(true);

            //cam.transform.rotation = Quaternion.Euler(0, 0, 0);
            //cameraScript.myGameObj = GameObject.Find("Goose");
            //cam.fieldOfView = 60f;

            frogInteractionScript.npcName = false;
            frogInteractionScript.frogText.SetActive(false);

            // cam.transform.LookAt(cameraScript.myGameObj.transform.position);

            lotScript.lotsCount += 1;
        }
    }

    public void BuildGoose()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 200 && !gooseReq.activeSelf)
        {
            worm.GetComponent<ResourceUpdate>().resources -= 200;

            gooseReq.SetActive(true);
            gooseStation.SetActive(true);

            wolf.SetActive(true);
            fourthPlot.SetActive(true);
            fourthPlotTrees.SetActive(true);

            //cam.transform.rotation = Quaternion.Euler(0, 0, 0);
            //cameraScript.myGameObj = GameObject.Find("Wolf");
            //cam.fieldOfView = 60f;

            gooseInteractionScript.npcName = false;
            gooseInteractionScript.gooseText.SetActive(false);

            lotScript.lotsCount += 1;
        }
    }

    public void BuildWolf() 
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 300 && !bone.activeSelf)
        {
            worm.GetComponent<ResourceUpdate>().resources -= 300;

            bone.SetActive(true);
            wolfHouseStation.SetActive(true);

            wolfInteractionScript.npcName = false;
            wolfInteractionScript.wolfText.SetActive(false);
        }
    }
}
