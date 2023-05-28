using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SparrowHexBuild : MonoBehaviour
{
    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    public Material DirtMaterial;
    public AudioSource Locked;

    public TMP_Text sparrowLevel;
    public GameObject worm;

    public GameObject SparrowWater;
    public GameObject SparrowGrass;
    public GameObject SparrowHex;
    public GameObject SparrowHex2;

    private void Awake()
    {
        resourceCountScript = resourceCountObject.GetComponent<ResourceCount>();
    }

    public void BuildHexSparrow()
    {
        if (resourceCountScript.resources >= 30 && !SparrowWater.activeSelf)
        {
            resourceCountScript.resources -= 30;

            SparrowWater.SetActive(true);

            SparrowHex.GetComponent<MeshRenderer>().material = DirtMaterial;

            GameObject.Find("HexBuildSparrow").GetComponent<SparrowHex>().menuOpen = 0;

            return;
        }

        if (resourceCountScript.resources >= 90 && !SparrowGrass.activeSelf)
        {
            resourceCountScript.resources -= 90;

            SparrowGrass.SetActive(true);

            SparrowHex2.GetComponent<MeshRenderer>().material = DirtMaterial;

            GameObject.Find("HexBuildSparrow2").GetComponent<SparrowHex2>().menuOpen = 0;

            return;
        }

        Locked.Play();
    }
}
