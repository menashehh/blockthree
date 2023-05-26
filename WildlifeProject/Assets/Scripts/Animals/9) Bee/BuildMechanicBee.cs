using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMechanicBee : MonoBehaviour
{
    public TMP_Text beeLevel;
    public TMP_Text frogLevel;
    public TMP_Text beeRequirement;

    public GameObject worm;

    public GameObject BeeStation;
    public GameObject BeeTree;
    public GameObject BeeHex;

    public AudioSource Locked;

    public void BuildBee()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !BeeStation.activeSelf && beeLevel.text == "Level 0")
        {
            BeeStation.SetActive(true);
            BeeHex.SetActive(true);

            beeLevel.text = "Level 1";
            beeRequirement.text = "Tree";

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && BeeTree.activeSelf && beeLevel.text == "Level 1")
        {
            beeLevel.text = "Level 2";
            beeRequirement.text = "Frog Level 4";

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && beeLevel.text == "Level 2" && (frogLevel.text == "Level 4" || frogLevel.text == "Level 5"))
        {
            beeLevel.text = "Level 3";
            beeRequirement.text = "Maximum Level Reached";

            return;
        }

        Locked.Play();
    }
}
