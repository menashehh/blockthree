using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyHexBuild : MonoBehaviour
{
    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    LotCount lotScript;
    public GameObject Lots;

    public Material SandMaterial;
    public AudioSource Locked;
    public AudioSource AnimalUnlock;

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
        resourceCountScript = resourceCountObject.GetComponent<ResourceCount>();
    }

    public void BuildHexFly()
    {
        if (resourceCountScript.resources >= 10 && !FlyReq.activeSelf)
        {
            resourceCountScript.resources -= 10;

            FlyReq.SetActive(true);

            FlyHex.GetComponent<MeshRenderer>().material = SandMaterial;

            GameObject.Find("HexBuildFly").GetComponent<FlyHex>().menuOpen = 0;

            if (!Bee.activeSelf)
            {
                Bee.SetActive(true);
                BeeLot.SetActive(true);

                AnimalUnlock.Play();

                lotScript.lotsCount += 1;
            }

            return;
        }

        if (resourceCountScript.resources >= 90 && !FlyGrass.activeSelf)
        {
            resourceCountScript.resources -= 90;

            FlyGrass.SetActive(true);

            FlyHex2.GetComponent<MeshRenderer>().material = SandMaterial;

            GameObject.Find("HexBuildFly2").GetComponent<FlyHex2>().menuOpen = 0;

            return;
        }

        Locked.Play();
    }
}
