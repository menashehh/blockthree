using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfHexBuild : MonoBehaviour
{
    public Material SandMaterial;

    public GameObject worm;

    public GameObject bone;
    public GameObject wolfStation;
    public GameObject WolfHex;

    public void BuildHexWolf()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !bone.activeSelf)
        {
            bone.SetActive(true);

            WolfHex.GetComponent<MeshRenderer>().material = SandMaterial;

            GameObject.Find("HexBuildWolf").GetComponent<WolfHex>().menuOpen = 0;

            return;
        }
    }
}
