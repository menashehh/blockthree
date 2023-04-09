using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NpcShowName2 : MonoBehaviour
{
    public GameObject Object; // NPC name (text)
    public GameObject BuildButton3;
    public GameObject BuildButton2;
    public GameObject BuildButton;
    public GameObject wolfText;

    public bool npcName; // Variable to store if the npc name text uis displayed or not
    private int menuOpen = 0; // Variable to store if the NPC interaction menu is open or not

    private GUIStyle guiStyle = new GUIStyle(); // Style for the GUI

    void Start()
    {
        Object.SetActive(false); // Hide the NPC name text
        BuildButton3.SetActive(false);
        BuildButton2.SetActive(false);
        BuildButton.SetActive(false);
        wolfText.SetActive(false);
        npcName = false;
    }

    private void OnMouseEnter()
    {
        if (Camera.main.fieldOfView == 40f)
        {
            Object.SetActive(true); // Unhide the NPC name text if the camera is zoomed in 
        }
    }

    private void OnMouseExit()
    {
        if (npcName == false)
        {
            Object.SetActive(false); // Hide the NPC name text if the mouse doesn't hover over the object and if the NPC interaction menu is hidden
        }
    }

    private void OnMouseDown()
    {
        if (menuOpen == 0 && Camera.main.fieldOfView == 40f)
        {
            if (npcName == false)
            {
                npcName = true; // Signal the GUI to draw the NPC interaction menu if the interaction menu is hidden
                Debug.Log("true");
            }
        }

        if (menuOpen == 1 && Camera.main.fieldOfView == 40f)
        {
            if (npcName == true)
            {
                npcName = false; // Signal the GUI to hide the NPC interaction menu if the interaction menu is open
                Debug.Log("false");
            }
        }

        // Open and close the interaction menu on mouse click
        if (menuOpen == 1)
        {
            menuOpen = 0;   
        }
        else if (Camera.main.fieldOfView == 40f)
        {
            menuOpen++;
        }
    }

    private void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(this.transform.position); // Position of the object
        var textSize = GUI.skin.label.CalcSize(new GUIContent("apple"));

        guiStyle.fontSize = 50; // Font size

        if (npcName == true && Camera.main.fieldOfView == 40f && !GameObject.Find("wolf"))
        {
            GUI.Label(new Rect(position.x + 10, Screen.height - position.y - 210, textSize.x, textSize.y), "Build apple!", guiStyle);
        }
        else if (Camera.main.fieldOfView == 40f && npcName == false && !GameObject.Find("wolf"))
        {
            guiStyle.fontSize = 75;
            GUI.Label(new Rect(position.x + 10, Screen.height - position.y - 210, textSize.x, textSize.y), "!", guiStyle);
        }
    }
    
    void Update()
    {
        if (BuildButton2)
        {
            if (npcName == true && Camera.main.fieldOfView == 40f && !GameObject.Find("wolf"))
            {
                BuildButton2.SetActive(true);
            }
            else BuildButton2.SetActive(false);
        }
    }
}
