using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMechanic : MonoBehaviour
{
    public GameObject Trees;
    public GameObject station;

    void Awake()
    {
        Trees.SetActive(false);
        station.SetActive(false);
    }
    public void Build()
    {
       if (station.GetComponent<ResourceUpdate>().resources >= 50 && !Trees.activeSelf)
        {
            Trees.SetActive(true);
            station.SetActive(true);
            station.GetComponent<ResourceUpdate>().resources -= 50;
        }
    }
}
