using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMechanicGoose : MonoBehaviour
{
    LotCount lotScript;
    public GameObject Lots;

    public TMP_Text gooseLevel;
    public TMP_Text gooseRequirement;

    public GameObject worm;

    public GameObject BeaverDam;

    public GameObject GooseStation;

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

            gooseLevel.text = "Level 1";
            gooseRequirement.text = "Maximum Level Reached";

            wolf.SetActive(true);
            wolfPlot.SetActive(true);

            lotScript.lotsCount += 1;

            return;
        }
    }
}
