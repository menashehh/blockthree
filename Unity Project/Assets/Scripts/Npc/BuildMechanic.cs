using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMechanic : MonoBehaviour
{
    public GameObject Trees;
    public GameObject station;
    public GameObject NPC;
    public GameObject secondPlot;

    private bool isBuilt = false;

    void Awake()
    {
        if (MainManager.Instance != null)
        {
            isBuilt = MainManager.Instance.isBuilt;
        }

        if (!isBuilt)
        {
            station.SetActive(false);
            Trees.SetActive(false);
            secondPlot.SetActive(false);
        }
    }
    public void Build()
    {
       if (NPC.GetComponent<ResourceUpdate>().resources >= 50 && !Trees.activeSelf)
        {
            NPC.GetComponent<ResourceUpdate>().resources -= 50;
            Trees.SetActive(true);
            station.SetActive(true);
            secondPlot.SetActive(true);
            isBuilt = true;
            MainManager.Instance.isBuilt = isBuilt;
        }
    }
}
