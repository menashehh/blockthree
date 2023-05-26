using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMechanicGoose : MonoBehaviour
{
    LotCount lotScript;
    public GameObject Lots;
    public AudioSource Locked;

    public TMP_Text gooseLevel;
    public TMP_Text gooseRequirement;

    public GameObject worm;

    public GameObject BeaverDam;

    public GameObject GooseStation;
    public GameObject GooseWater;
    public GameObject GooseHex;

    public GameObject wolf;
    public GameObject wolfPlot;

    private void Awake()
    {
        lotScript = Lots.GetComponent<LotCount>();
    }

    public void BuildGoose()
    {
        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && BeaverDam.activeSelf && gooseLevel.text == "Level 0")
        {
            GooseStation.SetActive(true);
            GooseHex.SetActive(true);

            gooseLevel.text = "Level 1";
            gooseRequirement.text = "Water";

            wolf.SetActive(true);
            wolfPlot.SetActive(true);

            lotScript.lotsCount += 1;

            return;
        }

        if (worm.GetComponent<ResourceUpdate>().resources >= 0 && GooseWater.activeSelf && gooseLevel.text == "Level 1")
        {
            gooseLevel.text = "Level 2";
            gooseRequirement.text = "Maximum Level Reached";

            return;
        }

        Locked.Play();
    }
}
