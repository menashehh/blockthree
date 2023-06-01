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

            GameObject.Find("HexBuildWolf").SetActive(false);
                            
            GameObject.Find("Hex Button Wolf").SetActive(false);

            return;
        }

        if (resourceCountScript.resources >= 90 && !wolfTree.activeSelf)
        {
            resourceCountScript.resources -= 90;

            wolfTree.SetActive(true);

            GameObject.Find("HexBuildWolf2").SetActive(false);

            GameObject.Find("Hex Button Wolf 2").SetActive(false);

            return;
        }

        Locked.Play();
    }
}
