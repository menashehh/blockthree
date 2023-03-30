using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMechanic : MonoBehaviour
{
    public GameObject Trees;
    public GameObject station;
    public GameObject NPC;
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
        }
    }
    public void Build()
    {
       if (NPC.GetComponent<ResourceUpdate>().resources >= 50 && !Trees.activeSelf)
        {
            Trees.SetActive(true);
            station.SetActive(true);
            NPC.GetComponent<ResourceUpdate>().resources -= 50;
            isBuilt = true;
            MainManager.Instance.isBuilt = isBuilt;
        }
    }
}
