using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMechanicBuzzard : MonoBehaviour
{
    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    public GameObject worm;

    public TMP_Text buzzardLevel;
    public TMP_Text buzzardRequirement;
    public GameObject buzzardStation;
    public GameObject BuzzardReq;
    public GameObject BuzzardGrass;
    public GameObject BuzzardHex;
    public GameObject BuzzardHex2;

    public AudioSource Locked;
    public AudioSource MaximumLevel;

    private void Awake()
    {
        resourceCountScript = resourceCountObject.GetComponent<ResourceCount>();
    }

    private void Update()
    {
        if (!BuzzardReq.activeSelf && buzzardLevel.text == "Level 0")
        {
            BuzzardHex.SetActive(true);
        }
    }

    public void BuildBuzzard()
    {
        if (resourceCountScript.resources >= 0 && BuzzardReq.activeSelf && buzzardLevel.text == "Level 0")
        {
            buzzardLevel.text = "Level 1";
            buzzardRequirement.text = "30 Resources to build idle station";

            Destroy(GameObject.Find("Buzzard").GetComponent<BuzzardInteraction>().text2);
            GameObject.Find("Buzzard").GetComponent<BuzzardInteraction>().levelPrefabLimit = 0;

            return;
        }

        if (resourceCountScript.resources >= 30 && !buzzardStation.activeSelf && buzzardLevel.text == "Level 1")
        {
            resourceCountScript.resources -= 30;

            buzzardStation.SetActive(true);
            BuzzardHex2.SetActive(true);

            buzzardLevel.text = "Level 2";
            buzzardRequirement.text = "Grass";

            Destroy(GameObject.Find("Buzzard").GetComponent<BuzzardInteraction>().text2);
            GameObject.Find("Buzzard").GetComponent<BuzzardInteraction>().levelPrefabLimit = 0;

            return;
        }

        if (resourceCountScript.resources >= 0 && BuzzardGrass.activeSelf && buzzardLevel.text == "Level 2")
        {
            MaximumLevel.Play();

            buzzardLevel.text = "Level 3";
            buzzardRequirement.text = "Maximum Level Reached";

            Destroy(GameObject.Find("Buzzard").GetComponent<BuzzardInteraction>().text2);
            GameObject.Find("Buzzard").GetComponent<BuzzardInteraction>().levelPrefabLimit = 0;

            return;
        }

        Locked.Play();
    }
}
