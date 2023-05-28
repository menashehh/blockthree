using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GooseHexBuild : MonoBehaviour
{
    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    public Material DirtMaterial;
    public AudioSource Locked;

    public GameObject worm;

    public TMP_Text gooseLevel;
    public GameObject GooseWater;
    public GameObject GooseHex;

    private void Awake()
    {
        resourceCountScript = resourceCountObject.GetComponent<ResourceCount>();
    }

    public void BuildHexGoose()
    {
        if (resourceCountScript.resources >= 30 && !GooseWater.activeSelf && gooseLevel.text == "Level 1")
        {
            resourceCountScript.resources -= 30;

            GooseWater.SetActive(true);

            GooseHex.GetComponent<MeshRenderer>().material = DirtMaterial;

            GameObject.Find("HexBuildGoose").GetComponent<GooseHex>().menuOpen = 0;

            return;
        }

        Locked.Play();
    }
}
