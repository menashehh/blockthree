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
        if (resourceCountScript.resources >= 150 && !FrogWater.activeSelf)
        {
            resourceCountScript.resources -= 150;

            FrogWater.SetActive(true);

            GameObject.Find("HexBuildFrog").SetActive(false);

            GameObject.Find("Hex Button Frog").SetActive(false);

            return;
        }

        if (resourceCountScript.resources >= 375 && !FrogTree.activeSelf)
        {
            resourceCountScript.resources -= 375;

            FrogTree.SetActive(true);

            GameObject.Find("HexBuildFrog2").SetActive(false);

            GameObject.Find("Hex Button Frog 2").SetActive(false);

            return;
        }

        if (resourceCountScript.resources >= 700 && !FrogGrass.activeSelf)
        {
            resourceCountScript.resources -= 700;

            FrogGrass.SetActive(true);

            GameObject.Find("HexBuildFrog3").SetActive(false);

            GameObject.Find("Hex Button Frog 3").SetActive(false);

            return;
        }

        Locked.Play();
    }
}
