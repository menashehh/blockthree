using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogHexBuild : MonoBehaviour
{
    public Material DirtMaterial;

    public GameObject worm;
    public GameObject FrogWater;
    public GameObject FrogHex;

    public void BuildHexFrog()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !FrogWater.activeSelf)
        {
            FrogWater.SetActive(true);

            FrogHex.GetComponent<MeshRenderer>().material = DirtMaterial;

            GameObject.Find("HexBuildFrog").GetComponent<FrogHex>().menuOpen = 0;

            return;
        }
    }
}
