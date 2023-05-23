using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogInteraction : MonoBehaviour
{
    // Script for the interactions with the frog (name, task, button)

    public GameObject frogText;
    public GameObject BuildButtonFrog;
    
    public bool npcName = false;
    private int menuOpen = 0;

    private GUIStyle guiStyle = new GUIStyle();

    private void OnMouseEnter()
    {
        if (Camera.main.fieldOfView == 80f && !GameObject.Find("Goose") && !GameObject.Find("Background") && !GameObject.Find("sparrowText") && !GameObject.Find("buzzardText") && !GameObject.Find("beaverText") && !GameObject.Find("flyText") && !GameObject.Find("beeText"))
        {
            frogText.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        if (!GameObject.Find("Goose") && !GameObject.Find("Background") && GameObject.Find("frogText"))
        {
            if (menuOpen == 0 && Camera.main.fieldOfView == 80f) npcName = true;

            if (menuOpen == 1 && Camera.main.fieldOfView == 80f) npcName = false;

            if (menuOpen == 1) menuOpen = 0; else if (Camera.main.fieldOfView == 80f) menuOpen++;
        }
    }

    private void OnMouseExit()
    {
        if (npcName == false && !GameObject.Find("Goose"))
        {
            frogText.SetActive(false);
        }
    }

    private void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(this.transform.position);
        var textSize = GUI.skin.label.CalcSize(new GUIContent("cloud"));

        guiStyle.fontSize = 50;

        if (!GameObject.Find("Background"))
        {
            if (npcName == true && Camera.main.fieldOfView == 80f && !GameObject.Find("Goose"))
            {
                GUI.Label(new Rect(position.x - 105, Screen.height - position.y - 100, textSize.x, textSize.y), "Build cloud!", guiStyle);
            }
            else if (npcName == false && Camera.main.fieldOfView == 80f && !GameObject.Find("Goose"))
            {
                guiStyle.fontSize = 75;
                GUI.Label(new Rect(position.x - 35, Screen.height - position.y - 100, textSize.x, textSize.y), "!", guiStyle);
            }
        }
    }

    private void Update()
    {
        if (npcName == true && Camera.main.fieldOfView == 80f && !GameObject.Find("Goose") && !GameObject.Find("Background"))
        {
            BuildButtonFrog.SetActive(true);
        }
        else BuildButtonFrog.SetActive(false);
    }
}
