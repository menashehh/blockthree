using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyHexBuild : MonoBehaviour
{
    public Material SandMaterial;

    public GameObject worm;

    public GameObject FlyReq;
    public GameObject FlyHex;

    public GameObject Bee;
    public GameObject BeeLot;

    public void BuildHexFly()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !FlyReq.activeSelf)
        {
            FlyReq.SetActive(true);

            FlyHex.GetComponent<MeshRenderer>().material = SandMaterial;

            GameObject.Find("HexBuildFly").GetComponent<FlyHex>().menuOpen = 0;

            if (!Bee.activeSelf)
            {
                Bee.SetActive(true);
                BeeLot.SetActive(true);
            }

            return;
        }
    }
}
