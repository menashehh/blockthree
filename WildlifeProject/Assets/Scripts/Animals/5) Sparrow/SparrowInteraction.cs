using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparrowInteraction : MonoBehaviour
{
    // Script for the interactions with the sparrow (name, task, button)

    public GameObject sparrowText;
    public GameObject BuildButtonSparrow;

    public bool npcName = false;
    private int menuOpen = 0;

    private GUIStyle guiStyle = new GUIStyle();

    private void OnMouseEnter()
    {
        if (Camera.main.fieldOfView == 80f && !GameObject.Find("Buzzard") && !GameObject.Find("Background") && !GameObject.Find("frogText") && !GameObject.Find("gooseText") && !GameObject.Find("wolfText"))
        {
            sparrowText.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        if (!GameObject.Find("Buzzard") && !GameObject.Find("Background") && GameObject.Find("sparrowText"))
        {
            if (menuOpen == 0 && Camera.main.fieldOfView == 80f) npcName = true;

            if (menuOpen == 1 && Camera.main.fieldOfView == 80f) npcName = false;

            if (menuOpen == 1) menuOpen = 0; else if (Camera.main.fieldOfView == 80f) menuOpen++;
        }
    }

    private void OnMouseExit()
    {
        if (npcName == false && !GameObject.Find("Buzzard"))
        {
            sparrowText.SetActive(false);
        }
    }

    private void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(this.transform.position);
        var textSize = GUI.skin.label.CalcSize(new GUIContent("sparrowReq"));

        guiStyle.fontSize = 50;

        if (!GameObject.Find("Background"))
        {
            if (npcName == true && Camera.main.fieldOfView == 80f && !GameObject.Find("Buzzard"))
            {
                GUI.Label(new Rect(position.x + 10, Screen.height - position.y - 210, textSize.x, textSize.y), "Build!", guiStyle);
            }
            else if (Camera.main.fieldOfView == 80f && npcName == false && !GameObject.Find("Buzzard"))
            {
                guiStyle.fontSize = 75;
                GUI.Label(new Rect(position.x + 10, Screen.height - position.y - 210, textSize.x, textSize.y), "!", guiStyle);
            }
        }
    }

    private void Update()
    {
        if (npcName == true && Camera.main.fieldOfView == 80f && !GameObject.Find("Buzzard") && !GameObject.Find("Background"))
        {
            BuildButtonSparrow.SetActive(true);
        }
        else BuildButtonSparrow.SetActive(false);
    }
}
