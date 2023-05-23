using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormInteraction : MonoBehaviour
{
    // Script for the interactions with the worm (name, task, button)

    public GameObject wormText;
    public GameObject BuildButtonWorm;

    public bool npcName = false;
    private int menuOpen = 0;

    private GUIStyle guiStyle = new GUIStyle();

    private void OnMouseEnter()
    {
        if (Camera.main.fieldOfView == 80f && !GameObject.Find("Frog") && !GameObject.Find("Background"))
        {
            wormText.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        if (!GameObject.Find("Frog") && !GameObject.Find("Background"))
        {
            if (menuOpen == 0 && Camera.main.fieldOfView == 80f) npcName = true;

            if (menuOpen == 1 && Camera.main.fieldOfView == 80f) npcName = false;

            if (menuOpen == 1) menuOpen = 0; else if (Camera.main.fieldOfView == 80f) menuOpen++;
        }
    }

    private void OnMouseExit()
    {
        if (npcName == false && !GameObject.Find("Frog"))
        {
            wormText.SetActive(false);
        }
    }

    private void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(this.transform.position);
        var textSize = GUI.skin.label.CalcSize(new GUIContent("apple"));

        guiStyle.fontSize = 50;

        if (!GameObject.Find("Background"))
        {
            if (npcName == true && Camera.main.fieldOfView == 80f && !GameObject.Find("Frog"))
            {
                GUI.Label(new Rect(position.x + 10, Screen.height - position.y - 210, textSize.x, textSize.y), "Build apple!", guiStyle);
            }
            else if (Camera.main.fieldOfView == 80f && npcName == false && !GameObject.Find("Frog"))
            {
                guiStyle.fontSize = 75;
                GUI.Label(new Rect(position.x + 10, Screen.height - position.y - 210, textSize.x, textSize.y), "!", guiStyle);
            }
        }
    }

    private void Update()
    {
        if (npcName == true && Camera.main.fieldOfView == 80f && !GameObject.Find("Frog") && !GameObject.Find("Background"))
        {
            BuildButtonWorm.SetActive(true);
        }
        else BuildButtonWorm.SetActive(false);
    }
}
