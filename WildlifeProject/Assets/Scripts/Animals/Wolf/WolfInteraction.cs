using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfInteraction : MonoBehaviour
{
    // Script for the interactions with the wolf (name, task, button)

    public GameObject frogText;
    public GameObject wormText;
    public GameObject wolfText;
    public GameObject BuildButtonFrog;
    public GameObject BuildButtonWorm;
    public GameObject BuildButtonWolf;

    public bool npcName = false;
    private int menuOpen = 0;

    private GUIStyle guiStyle = new GUIStyle();

    void Start()
    {
        frogText.SetActive(false);
        wormText.SetActive(false);
        wolfText.SetActive(false);
        BuildButtonFrog.SetActive(false);
        BuildButtonWorm.SetActive(false);
        BuildButtonWolf.SetActive(false);
    }

    private void OnMouseEnter()
    {
        if (Camera.main.fieldOfView == 40f && !GameObject.Find("Wolf House") && !GameObject.Find("Background"))
        {
            wolfText.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        if (!GameObject.Find("Wolf House") && !GameObject.Find("Background"))
        {
            if (menuOpen == 0 && Camera.main.fieldOfView == 40f) npcName = true;

            if (menuOpen == 1 && Camera.main.fieldOfView == 40f) npcName = false;

            if (menuOpen == 1) menuOpen = 0; else if (Camera.main.fieldOfView == 40f) menuOpen++;
        }
    }

    private void OnMouseExit()
    {
        if (npcName == false && !GameObject.Find("Wolf House"))
        {
            wolfText.SetActive(false);
        }
    }

    private void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(this.transform.position);
        var textSize = GUI.skin.label.CalcSize(new GUIContent("bone"));

        guiStyle.fontSize = 50;

        if (!GameObject.Find("Background"))
        {
            if (npcName == true && Camera.main.fieldOfView == 40f && !GameObject.Find("Bone"))
            {
                GUI.Label(new Rect(position.x + 10, Screen.height - position.y - 210, textSize.x, textSize.y), "Build bone!", guiStyle);
            }
            else if (Camera.main.fieldOfView == 40f && npcName == false && !GameObject.Find("Bone"))
            {
                guiStyle.fontSize = 75;
                GUI.Label(new Rect(position.x + 10, Screen.height - position.y - 210, textSize.x, textSize.y), "!", guiStyle);
            }
        }
    }

    private void Update()
    {
        if (npcName == true && Camera.main.fieldOfView == 40f && !GameObject.Find("Wolf House") && !GameObject.Find("Background"))
        {
            BuildButtonWolf.SetActive(true);
        }
        else BuildButtonWolf.SetActive(false);
    }
}
