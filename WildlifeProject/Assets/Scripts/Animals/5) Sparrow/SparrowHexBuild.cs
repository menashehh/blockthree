using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SparrowHexBuild : MonoBehaviour
{
    public Material DirtMaterial;
    public AudioSource Locked;

    public TMP_Text sparrowLevel;
    public GameObject worm;

    public GameObject SparrowWater;
    public GameObject SparrowGrass;
    public GameObject SparrowHex;
    public GameObject SparrowHex2;

    public void BuildHexSparrow()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !SparrowWater.activeSelf)
        {
            SparrowWater.SetActive(true);

            SparrowHex.GetComponent<MeshRenderer>().material = DirtMaterial;

            GameObject.Find("HexBuildSparrow").GetComponent<SparrowHex>().menuOpen = 0;

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !SparrowGrass.activeSelf)
        {
            SparrowGrass.SetActive(true);

            SparrowHex2.GetComponent<MeshRenderer>().material = DirtMaterial;

            GameObject.Find("HexBuildSparrow2").GetComponent<SparrowHex2>().menuOpen = 0;

            return;
        }

        Locked.Play();
    }
}
