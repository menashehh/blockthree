using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMechanicWolf : MonoBehaviour
{
    public TMP_Text wolfLevel;
    public TMP_Text wolfRequirement;

    public GameObject worm;

    public GameObject bone;
    public GameObject wolfStation;

    public void BuildWolf()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && bone.activeSelf && wolfLevel.text == "Level 0")
        {
            wolfLevel.text = "Level 1";
            wolfRequirement.text = "0 resources to build idle station";

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !wolfStation.activeSelf && wolfLevel.text == "Level 1")
        {
            wolfStation.SetActive(true);

            wolfLevel.text = "Level 2";
            wolfRequirement.text = "Maximum Level Reached";

            return;
        }
    }
}
