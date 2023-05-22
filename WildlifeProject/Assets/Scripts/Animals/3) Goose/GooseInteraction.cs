using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GooseInteraction : MonoBehaviour
{
    // Script for the interactions with the goose (name, task, button)

    public GameObject gooseText;
    public TMP_Text gooseLevel;
    public GameObject BuildButtonGoose;

    public bool npcName = false;
    private int menuOpen = 0;

    private GUIStyle guiStyle = new GUIStyle();

    private void OnMouseEnter()
    {
        if (Camera.main.fieldOfView == 80f && !GameObject.Find("Background") && !GameObject.Find("wormText") && !GameObject.Find("Hex Button Worm") && !GameObject.Find("frogText") && !GameObject.Find("Hex Button Frog") && !GameObject.Find("wolfText") && !GameObject.Find("Hex Button Wolf") && !GameObject.Find("sparrowText") && !GameObject.Find("buzzardText") && !GameObject.Find("Hex Button Buzzard") && !GameObject.Find("beaverText") && !GameObject.Find("flyText") && !GameObject.Find("Hex Button Fly") && !GameObject.Find("beeText"))
        {
            gooseText.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        if (!GameObject.Find("Background") && !GameObject.Find("wormText") && !GameObject.Find("Hex Button Worm") && !GameObject.Find("frogText") && !GameObject.Find("Hex Button Frog") && GameObject.Find("gooseText") && !GameObject.Find("wolfText") && !GameObject.Find("Hex Button Wolf") && !GameObject.Find("sparrowText") && !GameObject.Find("buzzardText") && !GameObject.Find("Hex Button Buzzard") && !GameObject.Find("beaverText") && !GameObject.Find("flyText") && !GameObject.Find("Hex Button Fly") && !GameObject.Find("beeText"))
        {
            if (menuOpen == 0 && Camera.main.fieldOfView == 80f) npcName = true;

            if (menuOpen == 1 && Camera.main.fieldOfView == 80f) npcName = false;

            if (menuOpen == 1) menuOpen = 0; else if (Camera.main.fieldOfView == 80f) menuOpen++;
        }
    }

    private void OnMouseExit()
    {
        if (npcName == false)
        {
            gooseText.SetActive(false);
        }
    }

    private void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(this.transform.position);
        var textSize = GUI.skin.label.CalcSize(new GUIContent("gooseReq"));
        guiStyle.fontSize = 50;

        if (!GameObject.Find("Background") && gooseLevel.text != "Level 1")
        {
            /*
            if (npcName == true && Camera.main.fieldOfView == 80f && !GameObject.Find("Wolf"))
            {
                GUI.Label(new Rect(position.x - 105, Screen.height - position.y - 100, textSize.x, textSize.y), "Build!", guiStyle);
            }
            else
            */
            if (npcName == false && Camera.main.fieldOfView == 80f /* && !GameObject.Find("Wolf") */)
            {
                guiStyle.fontSize = 75;
                GUI.Label(new Rect(position.x - 35, Screen.height - position.y - 100, textSize.x, textSize.y), "!", guiStyle);
            }
        }
    }

    private void Update()
    {
        if (npcName == true && Camera.main.fieldOfView == 80f /* && !GameObject.Find("Wolf") */ && !GameObject.Find("Background"))
        {
            BuildButtonGoose.SetActive(true);
        }
        else BuildButtonGoose.SetActive(false);
    }
}
