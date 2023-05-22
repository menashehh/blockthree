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
            buzzardStation.SetActive(true);;

            buzzardLevel.text = "Level 2";
            buzzardRequirement.text = "Maximum Level Reached";

            return;
        }
    }
}
