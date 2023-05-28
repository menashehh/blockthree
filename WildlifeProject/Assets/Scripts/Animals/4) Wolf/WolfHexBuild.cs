using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfHexBuild : MonoBehaviour
{
    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    public Material SandMaterial;
    public AudioSource Locked;

    public GameObject worm;

    public GameObject bone;
    public GameObject wolfStation;
    public GameObject wolfTree;
    public GameObject WolfHex;
    public GameObject WolfHex2;

    private void Awake()
    {
        resourceCountScript = resourceCountObject.GetComponent<ResourceCount>();
    }

    public void BuildHexWolf()
    {
        if (resourceCountScript.resources >= 10 && !bone.activeSelf)
        {
            resourceCountScript.resources -= 10;

            bone.SetActive(true);

            WolfHex.GetComponent<MeshRenderer>().material = SandMaterial;

            GameObject.Find("HexBuildWolf").GetComponent<WolfHex>().menuOpen = 0;

            return;
        }

        if (resourceCountScript.resources >= 90 && !wolfTree.activeSelf)
        {
            resourceCountScript.resources -= 90;

            wolfTree.SetActive(true);

            WolfHex2.GetComponent<MeshRenderer>().material = SandMaterial;

            GameObject.Find("HexBuildWolf2").GetComponent<WolfHex2>().menuOpen = 0;

            return;
        }

        Locked.Play();
    }
}
