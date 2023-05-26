using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyHexBuild : MonoBehaviour
{
    LotCount lotScript;
    public GameObject Lots;

    public Material SandMaterial;
    public AudioSource Locked;

    public GameObject worm;

    public GameObject FlyReq;
    public GameObject FlyGrass;
    public GameObject FlyHex;
    public GameObject FlyHex2;

    public GameObject Bee;
    public GameObject BeeLot;

    private void Awake()
    {
        lotScript = Lots.GetComponent<LotCount>();
    }

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

                lotScript.lotsCount += 1;
            }

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !FlyGrass.activeSelf)
        {
            FlyGrass.SetActive(true);

            FlyHex2.GetComponent<MeshRenderer>().material = SandMaterial;

            GameObject.Find("HexBuildFly2").GetComponent<FlyHex2>().menuOpen = 0;

            return;
        }

        Locked.Play();
    }
}
