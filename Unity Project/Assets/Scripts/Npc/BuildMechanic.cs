using System.Collections;
using System.Collections.Generic;
using System.Resources;
using TMPro;
using UnityEngine;

public class BuildMechanic : MonoBehaviour
{
    int phase = 1;
    public GameObject cloud;
    public GameObject station;
    public GameObject NPC;
    NpcShowName showNameScript;
    NpcShowName2 showNameScript2;
    NpcShowName3 showNameScript3;

    public GameObject secondPlot;
    public GameObject secondPlotTrees;
    public GameObject worm;
    public GameObject apple;
    public GameObject appleTree;

    public GameObject thirdPlot;
    public GameObject thirdPlotTrees;
    public GameObject wolfHouse;
    public GameObject wolf;
    public GameObject bone;

    public Camera cam;
    CameraPan cameraScript;

    private bool isBuilt = false;

    void Awake()
    {
        cameraScript = cam.GetComponent<CameraPan>();
        showNameScript = NPC.GetComponent<NpcShowName>();
        showNameScript2 = worm.GetComponent<NpcShowName2>();
        showNameScript3 = wolf.GetComponent<NpcShowName3>();

        if (MainManager.Instance != null)
        {
            isBuilt = MainManager.Instance.isBuilt;
            phase = MainManager.Instance.phase;
        }

        if (!isBuilt)
        {
            station.SetActive(false);
            cloud.SetActive(false);

            secondPlot.SetActive(false);
            secondPlotTrees.SetActive(false);
            worm.SetActive(false);
            apple.SetActive(false);
            appleTree.SetActive(false);

            thirdPlot.SetActive(false);
            thirdPlotTrees.SetActive(false);
            wolfHouse.SetActive(false);
            wolf.SetActive(false);
            bone.SetActive(false);
        }
        
        if (isBuilt && phase == 2)
        {
            cameraScript.myGameObj = GameObject.Find("worm");
            cam.fieldOfView = 60f;

            showNameScript.npcName = false;
            showNameScript.Object.SetActive(false);

            apple.SetActive(false);
            appleTree.SetActive(false);

            thirdPlot.SetActive(false);
            thirdPlotTrees.SetActive(false);
            wolfHouse.SetActive(false);
            wolf.SetActive(false);
            bone.SetActive(false);
        }

        if (isBuilt && phase == 3)
        {
            cameraScript.myGameObj = GameObject.Find("wolf");
            cam.fieldOfView = 30f;

            showNameScript2.npcName = false;
            showNameScript2.Object.SetActive(false);

            wolfHouse.SetActive(false);
            bone.SetActive(false);
        }

        if (isBuilt && phase == 4)
        {
            cameraScript.myGameObj = GameObject.Find("LotsCenter");
            cam.fieldOfView = 80f;

            showNameScript3.npcName = false;
            showNameScript3.Object.SetActive(false);
        }

    }

    public void Build()
    {
       if (NPC.GetComponent<ResourceUpdate>().resources >= 50 && !cloud.activeSelf)
        {
            NPC.GetComponent<ResourceUpdate>().resources -= 50;

            cloud.SetActive(true);
            station.SetActive(true);

            secondPlot.SetActive(true);
            secondPlotTrees.SetActive(true);
            worm.SetActive(true);

            isBuilt = true;
            phase = 2;
            MainManager.Instance.isBuilt = isBuilt;
            MainManager.Instance.phase = phase;

            cameraScript.myGameObj = GameObject.Find("worm");
            cam.fieldOfView = 60f;
            showNameScript.npcName = false;
            showNameScript.Object.SetActive(false);
            //cam.transform.LookAt(cameraScript.myGameObj.transform.position);
            //cam.transform.rotation = Quaternion.Euler(0, 0, 0);
        }

       if (NPC.GetComponent<ResourceUpdate>().resources >= 100 && !apple.activeSelf)
        {
            NPC.GetComponent<ResourceUpdate>().resources -= 100;

            apple.SetActive(true);
            appleTree.SetActive(true);

            thirdPlot.SetActive(true);
            thirdPlotTrees.SetActive(true);
            wolf.SetActive(true);

            phase = 3;
            MainManager.Instance.phase = phase;

            cameraScript.myGameObj = GameObject.Find("wolf");
            cam.fieldOfView = 30f;
            showNameScript2.npcName = false;
            showNameScript2.Object.SetActive(false);
        }

        if (NPC.GetComponent<ResourceUpdate>().resources >= 200 && !bone.activeSelf)
        {
            NPC.GetComponent<ResourceUpdate>().resources -= 200;

            bone.SetActive(true);
            wolfHouse.SetActive(true);

            phase = 4;
            MainManager.Instance.phase = phase;

            cameraScript.myGameObj = GameObject.Find("LotsCenter");
            cam.fieldOfView = 80f;
            showNameScript3.npcName = false;
            showNameScript3.Object.SetActive(false);
        }
    }
}
