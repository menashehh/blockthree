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

            GameObject.Find("HexBuildSparrow").SetActive(false);

            GameObject.Find("Hex Button Sparrow").SetActive(false);

            return;
        }

        if (resourceCountScript.resources >= 90 && !SparrowGrass.activeSelf)
        {
            resourceCountScript.resources -= 90;

            SparrowGrass.SetActive(true);

            GameObject.Find("HexBuildSparrow2").SetActive(false);

            GameObject.Find("Hex Button Sparrow 2").SetActive(false);

            return;
        }

        Locked.Play();
    }
}
