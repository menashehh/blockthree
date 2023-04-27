using System.Collections;
using System.Collections.Generic;
using System.Resources;
using TMPro;
using UnityEngine;

public class BuildMechanic : MonoBehaviour
{
    // Build mechanic for the buttons and gameplay loop

    int phase = 1;
    private bool isBuilt = false;

    FrogInteraction frogInteractionScript;
    WormInteraction wormInteractionScript;
    WolfInteraction wolfInteractionScript;
    CameraMechanics cameraScript;

    public Camera cam;

    public GameObject frog;
    public GameObject cloud;
    public GameObject flowerStation;

    public GameObject worm;
    public GameObject apple;
    public GameObject appleTreeStation;
    public GameObject secondPlot;
    public GameObject secondPlotTrees;

    public GameObject wolf;
    public GameObject bone;
    public GameObject wolfHouseStation;
    public GameObject thirdPlot;
    public GameObject thirdPlotTrees;

    void Awake()
    {
        cameraScript = cam.GetComponent<CameraMechanics>();
        frogInteractionScript = frog.GetComponent<FrogInteraction>();
        wormInteractionScript = worm.GetComponent<WormInteraction>();
        wolfInteractionScript = wolf.GetComponent<WolfInteraction>();

        if (MainManager.Instance != null)
        {
            isBuilt = MainManager.Instance.isBuilt;
            phase = MainManager.Instance.phase;
        }

        if (!isBuilt)
        {
            cloud.SetActive(false);
            flowerStation.SetActive(false);

            worm.SetActive(false);
            apple.SetActive(false);
            appleTreeStation.SetActive(false);
            secondPlot.SetActive(false);
            secondPlotTrees.SetActive(false);

            wolf.SetActive(false);
            bone.SetActive(false);
            wolfHouseStation.SetActive(false);
            thirdPlot.SetActive(false);
            thirdPlotTrees.SetActive(false);
        }
        
        if (isBuilt && phase == 2)
        {
            cameraScript.myGameObj = GameObject.Find("Worm");
            cam.fieldOfView = 60f;

            frogInteractionScript.npcName = false;
            frogInteractionScript.frogText.SetActive(false);

            apple.SetActive(false);
            appleTreeStation.SetActive(false);

            wolf.SetActive(false);
            bone.SetActive(false);
            wolfHouseStation.SetActive(false);
            thirdPlot.SetActive(false);
            thirdPlotTrees.SetActive(false);
        }

        if (isBuilt && phase == 3)
        {
            cameraScript.myGameObj = GameObject.Find("Wolf");
            cam.fieldOfView = 60f;

            wormInteractionScript.npcName = false;
            wormInteractionScript.wormText.SetActive(false);

            bone.SetActive(false);
            wolfHouseStation.SetActive(false);
        }

        if (isBuilt && phase == 4)
        {
            cameraScript.myGameObj = GameObject.Find("LotsCenter");
            cam.fieldOfView = 80f;

            wolfInteractionScript.npcName = false;
            wolfInteractionScript.wolfText.SetActive(false);
        }

    }

    public void Build()
    {
       if (frog.GetComponent<ResourceUpdate>().resources >= 50 && !cloud.activeSelf)
        {
            frog.GetComponent<ResourceUpdate>().resources -= 50;

            cloud.SetActive(true);
            flowerStation.SetActive(true);

            worm.SetActive(true);
            secondPlot.SetActive(true);
            secondPlotTrees.SetActive(true);

            isBuilt = true;
            phase = 2;
            MainManager.Instance.isBuilt = isBuilt;
            MainManager.Instance.phase = phase;

            cameraScript.myGameObj = GameObject.Find("Worm");
            cam.fieldOfView = 60f;
            frogInteractionScript.npcName = false;
            frogInteractionScript.frogText.SetActive(false);
            //cam.transform.LookAt(cameraScript.myGameObj.transform.position);
            cam.transform.rotation = Quaternion.Euler(0, 0, 0);
        }

       if (frog.GetComponent<ResourceUpdate>().resources >= 100 && !apple.activeSelf)
        {
            frog.GetComponent<ResourceUpdate>().resources -= 100;

            apple.SetActive(true);
            appleTreeStation.SetActive(true);

            wolf.SetActive(true);
            thirdPlot.SetActive(true);
            thirdPlotTrees.SetActive(true);

            phase = 3;
            MainManager.Instance.phase = phase;

            cameraScript.myGameObj = GameObject.Find("Wolf");
            cam.fieldOfView = 60f;
            wormInteractionScript.npcName = false;
            wormInteractionScript.wormText.SetActive(false);
        }

        if (frog.GetComponent<ResourceUpdate>().resources >= 200 && !bone.activeSelf)
        {
            frog.GetComponent<ResourceUpdate>().resources -= 200;

            bone.SetActive(true);
            wolfHouseStation.SetActive(true);

            phase = 4;
            MainManager.Instance.phase = phase;

            cameraScript.myGameObj = GameObject.Find("LotsCenter");
            cam.fieldOfView = 80f;
            wolfInteractionScript.npcName = false;
            wolfInteractionScript.wolfText.SetActive(false);
        }
    }
}
