using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMechanicBuzzard : MonoBehaviour
{
    public GameObject worm;

    public TMP_Text buzzardLevel;
    public TMP_Text buzzardRequirement;
    public GameObject buzzardStation;
    public GameObject BuzzardReq;
    public GameObject BuzzardGrass;
    public GameObject BuzzardHex2;

    public AudioSource Locked;

    public void BuildBuzzard()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && BuzzardReq.activeSelf && buzzardLevel.text == "Level 0")
        {
            buzzardLevel.text = "Level 1";
            buzzardRequirement.text = "0 resources to build idle station";

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !buzzardStation.activeSelf && buzzardLevel.text == "Level 1")
        {
            buzzardStation.SetActive(true);
            BuzzardHex2.SetActive(true);

            buzzardLevel.text = "Level 2";
            buzzardRequirement.text = "Grass";

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && BuzzardGrass.activeSelf && buzzardLevel.text == "Level 2")
        {
            buzzardLevel.text = "Level 3";
            buzzardRequirement.text = "Maximum Level Reached";

            return;
        }

        Locked.Play();
    }
}
