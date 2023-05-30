using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BeeHexBuild : MonoBehaviour
{
    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    public Material DirtMaterial;
    public AudioSource Locked;

    public GameObject worm;

    public TMP_Text beeLevel;
    public GameObject BeeTree;
    public GameObject BeeHex;

    private void Awake()
    {
        resourceCountScript = resourceCountObject.GetComponent<ResourceCount>();
    }

    public void BuildHexBee()
    {
        if (resourceCountScript.resources >= 30 && !BeeTree.activeSelf && beeLevel.text == "Level 1")
        {
            resourceCountScript.resources -= 30;

            BeeTree.SetActive(true);

            BeeHex.GetComponent<MeshRenderer>().material = DirtMaterial;

            GameObject.Find("HexBuildBee").GetComponent<BeeHex>().menuOpen = 0;

            return;
        }

        Locked.Play();
    }
}