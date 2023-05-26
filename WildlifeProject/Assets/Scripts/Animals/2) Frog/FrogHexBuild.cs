    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogHexBuild : MonoBehaviour
{
    public Material DirtMaterial;
    public AudioSource Locked;

    public GameObject worm;

    public GameObject FrogWater;
    public GameObject FrogTree;
    public GameObject FrogGrass;
    public GameObject FrogHex;
    public GameObject FrogHex2;
    public GameObject FrogHex3;

    public void BuildHexFrog()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !FrogWater.activeSelf)
        {
            FrogWater.SetActive(true);

            FrogHex.GetComponent<MeshRenderer>().material = DirtMaterial;

            GameObject.Find("HexBuildFrog").GetComponent<FrogHex>().menuOpen = 0;

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !FrogTree.activeSelf)
        {
            FrogTree.SetActive(true);

            FrogHex2.GetComponent<MeshRenderer>().material = DirtMaterial;

            GameObject.Find("HexBuildFrog2").GetComponent<FrogHex2>().menuOpen = 0;

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !FrogGrass.activeSelf)
        {
            FrogGrass.SetActive(true);

            FrogHex3.GetComponent<MeshRenderer>().material = DirtMaterial;

            GameObject.Find("HexBuildFrog3").GetComponent<FrogHex3>().menuOpen = 0;

            return;
        }

        Locked.Play();
    }
}
