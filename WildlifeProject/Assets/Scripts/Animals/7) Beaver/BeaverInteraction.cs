using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeaverInteraction : MonoBehaviour
{
    // Script for the interactions with the beaver (name, task, button)

    public GameObject beaverText;
    public GameObject BuildButtonBeaver;

    public bool npcName = false;
    private int menuOpen = 0;

    private GUIStyle guiStyle = new GUIStyle();

    private void OnMouseEnter()
    {
        if (Camera.main.fieldOfView == 80f && !GameObject.Find("Beaver Req") && !GameObject.Find("Background") && !GameObject.Find("frogText") && !GameObject.Find("gooseText") && !GameObject.Find("wolfText") && !GameObject.Find("flyText") && !GameObject.Find("beeText"))
        {
            beaverText.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        if (!GameObject.Find("Beaver Req") && !GameObject.Find("Background") && GameObject.Find("beaverText"))
        {
            if (menuOpen == 0 && Camera.main.fieldOfView == 80f) npcName = true;

            if (menuOpen == 1 && Camera.main.fieldOfView == 80f) npcName = false;

            if (menuOpen == 1) menuOpen = 0; else if (Camera.main.fieldOfView == 80f) menuOpen++;
        }
    }

    private void OnMouseExit()
    {
        if (npcName == false && !GameObject.Find("Beaver Req"))
        {
            beaverText.SetActive(false);
        }
    }

    private void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(this.transform.position);
        var textSize = GUI.skin.label.CalcSize(new GUIContent("beaverReq"));

        guiStyle.fontSize = 50;

        if (!GameObject.Find("Background"))
        {
            if (npcName == true && Camera.main.fieldOfView == 80f && !GameObject.Find("Beaver Req"))
            {
                GUI.Label(new Rect(position.x + 10, Screen.height - position.y - 210, textSize.x, textSize.y), "Build!", guiStyle);
            }
            else if (Camera.main.fieldOfView == 80f && npcName == false && !GameObject.Find("Beaver Req"))
            {
                guiStyle.fontSize = 75;
                GUI.Label(new Rect(position.x + 10, Screen.height - position.y - 210, textSize.x, textSize.y), "!", guiStyle);
            }
        }
    }

    private void Update()
    {
        if (npcName == true && Camera.main.fieldOfView == 80f && !GameObject.Find("Beaver Req") && !GameObject.Find("Background"))
        {
            BuildButtonBeaver.SetActive(true);
        }
        else BuildButtonBeaver.SetActive(false);
    }
}
