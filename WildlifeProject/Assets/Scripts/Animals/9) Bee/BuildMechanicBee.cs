using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMechanicBee : MonoBehaviour
{
    public TMP_Text beeLevel;
    public TMP_Text beeRequirement;

    public GameObject worm;

    public GameObject BeeStation;

    public void BuildBee()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && !BeeStation.activeSelf && beeLevel.text == "Level 0")
        {
            BeeStation.SetActive(true);

            beeLevel.text = "Level 1";
            beeRequirement.text = "Maximum Level Reached";

            return;
        }
    }
}
