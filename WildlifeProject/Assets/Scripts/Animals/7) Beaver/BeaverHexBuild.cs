using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BeaverHexBuild : MonoBehaviour
{
    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    public Material DirtMaterial;
    public AudioSource Locked;

    public GameObject worm;

    public TMP_Text beaverLevel;
    public GameObject BeaverTree;
    public GameObject BeaverHex;

    private void Awake()
    {
        resourceCountScript = resourceCountObject.GetComponent<ResourceCount>();
    }

    public void BuildHexBeaver()
    {
        if (resourceCountScript.resources >= 90 && !BeaverTree.activeSelf && beaverLevel.text == "Level 2")
        {
            resourceCountScript.resources -= 90;

            BeaverTree.SetActive(true);

            BeaverHex.GetComponent<MeshRenderer>().material = DirtMaterial;

            GameObject.Find("HexBuildBeaver").GetComponent<BeaverHex>().menuOpen = 0;

            return;
        }

        Locked.Play();
    }
}
