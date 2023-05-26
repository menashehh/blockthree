using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BeaverInteraction : MonoBehaviour
{
    // Script for the interactions with the beaver (name, task, button)

    Highlight HighlightScript;

    public GameObject beaverText;
    public TMP_Text beaverLevel;
    public GameObject BuildButtonBeaver;

    public bool npcName = false;
    public int menuOpen = 0;

    private GUIStyle guiStyle = new GUIStyle();

    private void Start()
    {
        HighlightScript = GetComponent<Highlight>();
    }

    private void OnMouseEnter()
    {
        if (Camera.main.fieldOfView == 80f && !GameObject.Find("Background")
            && !GameObject.Find("wormText") && !GameObject.Find("Hex Button Worm") && !GameObject.Find("Hex Button Worm 2") && !GameObject.Find("Hex Button Worm 3") && !GameObject.Find("Hex Button Worm 4")
            && !GameObject.Find("frogText") && !GameObject.Find("Hex Button Frog") && !GameObject.Find("Hex Button Frog 2") && !GameObject.Find("Hex Button Frog 3")
            && !GameObject.Find("gooseText") && !GameObject.Find("Hex Button Goose")
            && !GameObject.Find("wolfText") && !GameObject.Find("Hex Button Wolf") && !GameObject.Find("Hex Button Wolf 2")
            && !GameObject.Find("sparrowText") && !GameObject.Find("Hex Button Sparrow") && !GameObject.Find("Hex Button Sparrow 2")
            && !GameObject.Find("buzzardText") && !GameObject.Find("Hex Button Buzzard") && !GameObject.Find("Hex Button Buzzard 2")
            && !GameObject.Find("Hex Button Beaver")
            && !GameObject.Find("flyText") && !GameObject.Find("Hex Button Fly") && !GameObject.Find("Hex Button Fly 2")
            && !GameObject.Find("beeText") && !GameObject.Find("Hex Button Bee"))
        {
            beaverText.SetActive(true);

            if (!GameObject.Find("Build Button Beaver")) HighlightScript.ToggleHighlight(true);
        }
    }

    private void OnMouseDown()
    {
        if (!GameObject.Find("Background") && GameObject.Find("beaverText"))
        {
            if (menuOpen == 0 && Camera.main.fieldOfView == 80f) npcName = true;

            if (menuOpen == 1 && Camera.main.fieldOfView == 80f) npcName = false;

            if (menuOpen == 1) menuOpen = 0; else if (Camera.main.fieldOfView == 80f) menuOpen++;

            HighlightScript.ToggleHighlight(false);
        }
    }

    private void OnMouseExit()
    {
        if (npcName == false)
        {
            beaverText.SetActive(false);
            HighlightScript.ToggleHighlight(false);
        }
    }

    private void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(this.transform.position);
        var textSize = GUI.skin.label.CalcSize(new GUIContent("beaverReq"));

        guiStyle.fontSize = 50;

        if (!GameObject.Find("Background") && beaverLevel.text != "Level 3")
        {
            if (Camera.main.fieldOfView == 80f && npcName == false)
            {
                guiStyle.fontSize = 75;
                GUI.Label(new Rect(position.x + 10, Screen.height - position.y - 210, textSize.x, textSize.y), "!", guiStyle);
            }
        }
    }

    private void Update()
    {
        if (npcName == true && Camera.main.fieldOfView == 80f && !GameObject.Find("Background"))
        {
            BuildButtonBeaver.SetActive(true);
        }
        else BuildButtonBeaver.SetActive(false);
    }
}
