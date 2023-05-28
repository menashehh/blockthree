    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogHexBuild : MonoBehaviour
{
    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    public Material DirtMaterial;
    public AudioSource Locked;

    public GameObject worm;

    public GameObject FrogWater;
    public GameObject FrogTree;
    public GameObject FrogGrass;
    public GameObject FrogHex;
    public GameObject FrogHex2;
    public GameObject FrogHex3;

    private void Awake()
    {
        resourceCountScript = resourceCountObject.GetComponent<ResourceCount>();
    }

    public void BuildHexFrog()
    {
        if (resourceCountScript.resources >= 10 && !FrogWater.activeSelf)
        {
            resourceCountScript.resources -= 10;

            FrogWater.SetActive(true);

            FrogHex.GetComponent<MeshRenderer>().material = DirtMaterial;

            GameObject.Find("HexBuildFrog").GetComponent<FrogHex>().menuOpen = 0;

            return;
        }

        if (resourceCountScript.resources >= 90 && !FrogTree.activeSelf)
        {
            resourceCountScript.resources -= 90;

            FrogTree.SetActive(true);

            FrogHex2.GetComponent<MeshRenderer>().material = DirtMaterial;

            GameObject.Find("HexBuildFrog2").GetComponent<FrogHex2>().menuOpen = 0;

            return;
        }

        if (resourceCountScript.resources >= 810 && !FrogGrass.activeSelf)
        {
            resourceCountScript.resources -= 810;

            FrogGrass.SetActive(true);

            FrogHex3.GetComponent<MeshRenderer>().material = DirtMaterial;

            GameObject.Find("HexBuildFrog3").GetComponent<FrogHex3>().menuOpen = 0;

            return;
        }

        Locked.Play();
    }
}
