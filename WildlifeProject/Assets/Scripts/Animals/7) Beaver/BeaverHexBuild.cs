using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BeaverHexBuild : MonoBehaviour
{
    public Material DirtMaterial;
    public AudioSource Locked;

    public GameObject worm;

    public TMP_Text beaverLevel;
    public GameObject BeaverTree;
    public GameObject BeaverHex;

    public void BuildHexBeaver()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !BeaverTree.activeSelf && beaverLevel.text == "Level 2")
        {
            BeaverTree.SetActive(true);

            BeaverHex.GetComponent<MeshRenderer>().material = DirtMaterial;

            GameObject.Find("HexBuildBeaver").GetComponent<BeaverHex>().menuOpen = 0;

            return;
        }

        Locked.Play();
    }
}
