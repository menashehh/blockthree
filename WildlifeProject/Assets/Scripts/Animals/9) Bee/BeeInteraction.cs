using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeInteraction : MonoBehaviour
{
    // Script for the interactions with the bee (name, task, button)

    public GameObject beeText;
    public GameObject BuildButtonBee;

    public bool npcName = false;
    private int menuOpen = 0;

    private GUIStyle guiStyle = new GUIStyle();

    private void OnMouseEnter()
    {
        if (Camera.main.fieldOfView == 80f && !GameObject.Find("Bee Req") && !GameObject.Find("Background") && !GameObject.Find("frogText") && !GameObject.Find("gooseText") && !GameObject.Find("wolfText") && !GameObject.Find("beaverText"))
        {
            beeText.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        if (!GameObject.Find("Bee Req") && !GameObject.Find("Background") && GameObject.Find("beeText"))
        {
            if (menuOpen == 0 && Camera.main.fieldOfView == 80f) npcName = true;

            if (menuOpen == 1 && Camera.main.fieldOfView == 80f) npcName = false;

            if (menuOpen == 1) menuOpen = 0; else if (Camera.main.fieldOfView == 80f) menuOpen++;
        }
    }

    private void OnMouseExit()
    {
        if (npcName == false && !GameObject.Find("Bee Req"))
        {
            beeText.SetActive(false);
        }
    }

    private void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(this.transform.position);
        var textSize = GUI.skin.label.CalcSize(new GUIContent("beeReq"));

        guiStyle.fontSize = 50;

        if (!GameObject.Find("Background"))
        {
            if (npcName == true && Camera.main.fieldOfView == 80f && !GameObject.Find("Bee Req"))
            {
                GUI.Label(new Rect(position.x + 10, Screen.height - position.y - 210, textSize.x, textSize.y), "Build!", guiStyle);
            }
            else if (Camera.main.fieldOfView == 80f && npcName == false && !GameObject.Find("Bee Req"))
            {
                guiStyle.fontSize = 75;
                GUI.Label(new Rect(position.x + 10, Screen.height - position.y - 210, textSize.x, textSize.y), "!", guiStyle);
            }
        }
    }

    private void Update()
    {
        if (npcName == true && Camera.main.fieldOfView == 80f && !GameObject.Find("Bee Req") && !GameObject.Find("Background"))
        {
            BuildButtonBee.SetActive(true);
        }
        else BuildButtonBee.SetActive(false);
    }
}
