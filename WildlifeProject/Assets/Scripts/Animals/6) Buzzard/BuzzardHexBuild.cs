using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuzzardHexBuild : MonoBehaviour
{
    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    LotCount lotScript;
    public GameObject Lots;

    public Material SandMaterial;
    public AudioSource Locked;
    public AudioSource AnimalUnlock;

    public GameObject worm;

    public GameObject BuzzardReq;
    public GameObject BuzzardGrass;
    public GameObject BuzzardHex;
    public GameObject BuzzardHex2;

    public GameObject Apple;
    public GameObject Fly;
    public GameObject FlyLot;

    public GameObject Cone;
    public GameObject Beaver;
    public GameObject BeaverLot;

    private void Awake()
    {
        lotScript = Lots.GetComponent<LotCount>();
        resourceCountScript = resourceCountObject.GetComponent<ResourceCount>();
    }

    public void BuildHexBuzzard()
    {
        if (resourceCountScript.resources >= 10 && !BuzzardReq.activeSelf)
        {
            resourceCountScript.resources -= 10;

            BuzzardReq.SetActive(true);

            GameObject.Find("HexBuildBuzzard").SetActive(false);

            GameObject.Find("Hex Button Buzzard").SetActive(false);

            Apple.SetActive(true);
            Fly.SetActive(true);
            FlyLot.SetActive(true);

            Cone.SetActive(true);
            Beaver.SetActive(true);
            BeaverLot.SetActive(true);

            AnimalUnlock.Play();

            lotScript.lotsCount += 2;

            return;
        }

        if (resourceCountScript.resources >= 90 && !BuzzardGrass.activeSelf)
        {
            resourceCountScript.resources -= 90;

            BuzzardGrass.SetActive(true);

            GameObject.Find("HexBuildBuzzard2").SetActive(false);

            GameObject.Find("Hex Button Buzzard 2").SetActive(false);

            return;
        }

        Locked.Play();
    }
}
