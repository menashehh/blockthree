using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMechanicFly : MonoBehaviour
{
    public TMP_Text flyLevel;
    public TMP_Text flyRequirement;

    public GameObject worm;

    public GameObject FlyReq;
    public GameObject FlyStation;
    public GameObject FlyGrass;
    public GameObject FlyHex2;

    public AudioSource Locked;

    public void BuildFly()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && FlyReq.activeSelf && flyLevel.text == "Level 0")
        {
            flyLevel.text = "Level 1";
            flyRequirement.text = "0 resources to build idle station";

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !FlyStation.activeSelf && flyLevel.text == "Level 1")
        {
            FlyStation.SetActive(true);
            FlyHex2.SetActive(true);

            flyLevel.text = "Level 2";
            flyRequirement.text = "Grass";

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && FlyGrass.activeSelf && flyLevel.text == "Level 2")
        {
            flyLevel.text = "Level 3";
            flyRequirement.text = "Maximum Level Reached";

            return;
        }

        Locked.Play();
    }
}
