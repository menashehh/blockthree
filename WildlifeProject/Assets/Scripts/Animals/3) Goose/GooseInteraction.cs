using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GooseInteraction : MonoBehaviour
{
    // Script for the interactions with the goose (name, task, button)

    Highlight HighlightScript;

    public GameObject gooseText;
    public TMP_Text gooseLevel;
    public GameObject BuildButtonGoose;

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
             && !GameObject.Find("Hex Button Goose")
             && !GameObject.Find("wolfText") && !GameObject.Find("Hex Button Wolf") && !GameObject.Find("Hex Button Wolf 2")
             && !GameObject.Find("sparrowText") && !GameObject.Find("Hex Button Sparrow") && !GameObject.Find("Hex Button Sparrow 2")
             && !GameObject.Find("buzzardText") && !GameObject.Find("Hex Button Buzzard") && !GameObject.Find("Hex Button Buzzard 2")
             && !GameObject.Find("beaverText") && !GameObject.Find("Hex Button Beaver")
             && !GameObject.Find("flyText") && !GameObject.Find("Hex Button Fly") && !GameObject.Find("Hex Button Fly 2")
             && !GameObject.Find("beeText") && !GameObject.Find("Hex Button Bee"))
        {
            gooseText.SetActive(true);

            if (!GameObject.Find("Build Button Goose")) HighlightScript.ToggleHighlight(true);
        }
    }

    private void OnMouseDown()
    {
        if (!GameObject.Find("Background") && GameObject.Find("gooseText"))
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
            gooseText.SetActive(false);
            HighlightScript.ToggleHighlight(false);
        }
    }

    private void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(this.transform.position);
        var textSize = GUI.skin.label.CalcSize(new GUIContent("gooseReq"));
        guiStyle.fontSize = 50;

        if (!GameObject.Find("Background") && gooseLevel.text != "Level 2")
        {
            if (npcName == false && Camera.main.fieldOfView == 80f)
            {
                guiStyle.fontSize = 75;
                GUI.Label(new Rect(position.x - 35, Screen.height - position.y - 100, textSize.x, textSize.y), "!", guiStyle);
            }
        }
    }

    private void Update()
    {
        if (npcName == true && Camera.main.fieldOfView == 80f && !GameObject.Find("Background"))
        {
            BuildButtonGoose.SetActive(true);
        }
        else BuildButtonGoose.SetActive(false);
    }
}
