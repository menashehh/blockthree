using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuzzardInteraction : MonoBehaviour
{
    // Script for the interactions with the buzzard (name, task, button)

    public GameObject buzzardText;
    public GameObject BuildButtonBuzzard;

    public bool npcName = false;
    private int menuOpen = 0;

    private GUIStyle guiStyle = new GUIStyle();

    private void OnMouseEnter()
    {
        if (Camera.main.fieldOfView == 80f && !GameObject.Find("Beaver") && !GameObject.Find("Background") && !GameObject.Find("frogText") && !GameObject.Find("gooseText") && !GameObject.Find("wolfText"))
        {
            buzzardText.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        if (!GameObject.Find("Beaver") && !GameObject.Find("Background") && GameObject.Find("buzzardText"))
        {
            if (menuOpen == 0 && Camera.main.fieldOfView == 80f) npcName = true;

            if (menuOpen == 1 && Camera.main.fieldOfView == 80f) npcName = false;

            if (menuOpen == 1) menuOpen = 0; else if (Camera.main.fieldOfView == 80f) menuOpen++;
        }
    }

    private void OnMouseExit()
    {
        if (npcName == false && !GameObject.Find("Beaver"))
        {
            buzzardText.SetActive(false);
        }
    }

    private void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(this.transform.position);
        var textSize = GUI.skin.label.CalcSize(new GUIContent("buzzardReq"));

        guiStyle.fontSize = 50;

        if (!GameObject.Find("Background"))
        {
            if (npcName == true && Camera.main.fieldOfView == 80f && !GameObject.Find("Beaver"))
            {
                GUI.Label(new Rect(position.x + 10, Screen.height - position.y - 210, textSize.x, textSize.y), "Build!", guiStyle);
            }
            else if (Camera.main.fieldOfView == 80f && npcName == false && !GameObject.Find("Beaver"))
            {
                guiStyle.fontSize = 75;
                GUI.Label(new Rect(position.x + 10, Screen.height - position.y - 210, textSize.x, textSize.y), "!", guiStyle);
            }
        }
    }

    private void Update()
    {
        if (npcName == true && Camera.main.fieldOfView == 80f && !GameObject.Find("Beaver") && !GameObject.Find("Background"))
        {
            BuildButtonBuzzard.SetActive(true);
        }
        else BuildButtonBuzzard.SetActive(false);
    }
}
