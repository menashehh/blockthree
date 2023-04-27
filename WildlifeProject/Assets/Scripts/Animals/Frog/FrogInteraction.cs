using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogInteraction : MonoBehaviour
{
    // Script for the interactions with the frog (name, task, button)

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
        if (Camera.main.fieldOfView == 40f && !GameObject.Find("Worm"))
        {
            frogText.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        if (!GameObject.Find("Worm"))
        {
            if (menuOpen == 0 && Camera.main.fieldOfView == 40f) npcName = true;

            if (menuOpen == 1 && Camera.main.fieldOfView == 40f) npcName = false;

            if (menuOpen == 1) menuOpen = 0; else if (Camera.main.fieldOfView == 40f) menuOpen++;
        }
    }

    private void OnMouseExit()
    {
        if (npcName == false && !GameObject.Find("Worm"))
        {
            frogText.SetActive(false);
        }
    }

    private void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(this.transform.position);
        var textSize = GUI.skin.label.CalcSize(new GUIContent("cloud"));

        guiStyle.fontSize = 50;

        if (npcName == true && Camera.main.fieldOfView == 40f && !GameObject.Find("Worm"))
        {
            GUI.Label(new Rect(position.x - 105, Screen.height - position.y - 100, textSize.x, textSize.y), "Build cloud!", guiStyle);
        }
        else if (npcName == false && Camera.main.fieldOfView == 40f && !GameObject.Find("Worm"))
        {
            guiStyle.fontSize = 75;
            GUI.Label(new Rect(position.x - 35, Screen.height - position.y - 100, textSize.x, textSize.y), "!", guiStyle);
        }
    }

    private void Update()
    {
        if (npcName == true && Camera.main.fieldOfView == 40f && !GameObject.Find("Worm"))
        {
            BuildButtonFrog.SetActive(true);
        }
        else BuildButtonFrog.SetActive(false);
    }
}
