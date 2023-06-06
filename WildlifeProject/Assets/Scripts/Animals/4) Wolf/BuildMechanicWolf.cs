using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMechanicWolf : MonoBehaviour
{
    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    public TMP_Text wolfLevel;
    public TMP_Text wolfRequirement;

    public GameObject worm;

    public GameObject bone;
    public GameObject wolfStation;
    public GameObject wolfTree;
    public GameObject WolfHex;                                      
    public GameObject WolfHex2;

    public AudioSource Locked;
    public AudioSource MaximumLevel;

    private void Awake()
    {
        resourceCountScript = resourceCountObject.GetComponent<ResourceCount>();
    }

    private void Update()
    {
        if (!bone.activeSelf && wolfLevel.text == "Level 0")
        {
            WolfHex.SetActive(true);
        }
    }

    public void BuildWolf()
    {
        if (resourceCountScript.resources >= 0 && bone.activeSelf && wolfLevel.text == "Level 0")
        {
            wolfLevel.text = "Level 1";
            wolfRequirement.text = "30 Resources to build idle station";

            Destroy(GameObject.Find("Wolf").GetComponent<WolfInteraction>().text2);
            GameObject.Find("Wolf").GetComponent<WolfInteraction>().levelPrefabLimit = 0;

            return;
        }

        if (resourceCountScript.resources >= 30 && !wolfStation.activeSelf && wolfLevel.text == "Level 1")
        {
            resourceCountScript.resources -= 30;

            wolfStation.SetActive(true);
            WolfHex2.SetActive(true);

            wolfLevel.text = "Level 2";
            wolfRequirement.text = "Tree";

            Destroy(GameObject.Find("Wolf").GetComponent<WolfInteraction>().text2);
            GameObject.Find("Wolf").GetComponent<WolfInteraction>().levelPrefabLimit = 0;

            return;
        }

        if (resourceCountScript.resources >= 0 && wolfTree.activeSelf && wolfLevel.text == "Level 2")
        {
            MaximumLevel.Play();

            wolfLevel.text = "Level 3";
            wolfRequirement.text = "Maximum Level Reached";

            Destroy(GameObject.Find("Wolf").GetComponent<WolfInteraction>().text2);
            GameObject.Find("Wolf").GetComponent<WolfInteraction>().levelPrefabLimit = 0;

            return;
        }

        Locked.Play();
    }
}
