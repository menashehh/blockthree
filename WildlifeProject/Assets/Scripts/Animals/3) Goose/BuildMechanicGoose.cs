using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMechanicGoose : MonoBehaviour
{
    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    LotCount lotScript;
    public GameObject Lots;
    public AudioSource Locked;
    public AudioSource AnimalUnlock;
    public AudioSource MaximumLevel;

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
        resourceCountScript = resourceCountObject.GetComponent<ResourceCount>();
    }

    public void BuildGoose()
    {
        if (resourceCountScript.resources >= 0 && BeaverDam.activeSelf && gooseLevel.text == "Level 0")
        {
            GooseStation.SetActive(true);
            GooseHex.SetActive(true);

            gooseLevel.text = "Level 1";
            gooseRequirement.text = "Water";

            wolf.SetActive(true);
            wolfPlot.SetActive(true);

            AnimalUnlock.Play();

            lotScript.lotsCount += 1;

            return;
        }

        if (resourceCountScript.resources >= 0 && GooseWater.activeSelf && gooseLevel.text == "Level 1")
        {
            MaximumLevel.Play();

            gooseLevel.text = "Level 2";
            gooseRequirement.text = "Maximum Level Reached";

            return;
        }

        Locked.Play();
    }
}
