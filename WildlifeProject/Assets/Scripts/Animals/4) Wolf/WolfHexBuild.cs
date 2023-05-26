using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfHexBuild : MonoBehaviour
{
    public Material SandMaterial;
    public AudioSource Locked;

    public GameObject worm;

    public GameObject bone;
    public GameObject wolfStation;
    public GameObject wolfTree;
    public GameObject WolfHex;
    public GameObject WolfHex2;

    public void BuildHexWolf()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !bone.activeSelf)
        {
            bone.SetActive(true);

            WolfHex.GetComponent<MeshRenderer>().material = SandMaterial;

            GameObject.Find("HexBuildWolf").GetComponent<WolfHex>().menuOpen = 0;

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !wolfTree.activeSelf)
        {
            wolfTree.SetActive(true);

            WolfHex2.GetComponent<MeshRenderer>().material = SandMaterial;

            GameObject.Find("HexBuildWolf2").GetComponent<WolfHex2>().menuOpen = 0;

            return;
        }

        Locked.Play();
    }
}
