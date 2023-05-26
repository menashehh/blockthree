using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GooseHexBuild : MonoBehaviour
{
    public Material DirtMaterial;
    public AudioSource Locked;

    public GameObject worm;

    public TMP_Text gooseLevel;
    public GameObject GooseWater;
    public GameObject GooseHex;

    public void BuildHexGoose()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !GooseWater.activeSelf && gooseLevel.text == "Level 1")
        {
            GooseWater.SetActive(true);

            GooseHex.GetComponent<MeshRenderer>().material = DirtMaterial;

            GameObject.Find("HexBuildGoose").GetComponent<GooseHex>().menuOpen = 0;

            return;
        }

        Locked.Play();
    }
}
