using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BeeHexBuild : MonoBehaviour
{
    public Material DirtMaterial;
    public AudioSource Locked;

    public GameObject worm;

    public TMP_Text beeLevel;
    public GameObject BeeTree;
    public GameObject BeeHex;

    public void BuildHexBee()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !BeeTree.activeSelf && beeLevel.text == "Level 1")
        {
            BeeTree.SetActive(true);

            BeeHex.GetComponent<MeshRenderer>().material = DirtMaterial;

            GameObject.Find("HexBuildBee").GetComponent<BeeHex>().menuOpen = 0;

            return;
        }

        Locked.Play();
    }
}
