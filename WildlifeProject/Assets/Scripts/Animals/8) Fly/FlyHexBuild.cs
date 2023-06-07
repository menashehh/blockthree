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
        if (resourceCountScript.resources >= 1230 && !FlyReq.activeSelf)
        {
            resourceCountScript.resources -= 1230;

            FlyReq.SetActive(true);

            GameObject.Find("HexBuildFly").SetActive(false);

            GameObject.Find("Hex Button Fly").SetActive(false);

            if (!Bee.activeSelf)
            {
                Bee.SetActive(true);
                BeeLot.SetActive(true);

                AnimalUnlock.Play();

                lotScript.lotsCount += 1;
            }

            return;
        }

        if (resourceCountScript.resources >= 3230 && !FlyGrass.activeSelf)
        {
            resourceCountScript.resources -= 3230;

            FlyGrass.SetActive(true);

            GameObject.Find("HexBuildFly2").SetActive(false);

            GameObject.Find("Hex Button Fly 2").SetActive(false);

            return;
        }

        Locked.Play();
    }
}
