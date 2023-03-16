using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcShowName : MonoBehaviour
{
    public GameObject Object; // NPC name (text)

    public bool npcName = false; // Variable to store if the npc name text uis displayed or not
    private int menuOpen = 0; // Variable to store if the NPC interaction menu is open or not

    private GUIStyle guiStyle = new GUIStyle(); // Style for the GUI

    void Start()
    {
        Object.SetActive(false); // Hide the NPC name text
    }

    private void OnMouseEnter()
    {
        if (Camera.main.fieldOfView == 20f && (!GameObject.Find("NPC1").GetComponent<NpcShowName>().Object.activeSelf && !GameObject.Find("NPC2").GetComponent<NpcShowName>().Object.activeSelf))
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
        if (menuOpen == 0 && Camera.main.fieldOfView == 20f)
        {
            if (npcName == false)
            {
                npcName = true; // Signal the GUI to draw the NPC interaction menu if the interaction menu is hidden
                Debug.Log("true");
            }
        }

        if (menuOpen == 1 && Camera.main.fieldOfView == 20f)
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
        else if (Camera.main.fieldOfView == 20f)
        { 
            menuOpen++;
        }
    }

    private void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(this.transform.position); // Position of the object
        var textSize = GUI.skin.label.CalcSize(new GUIContent("Give food"));

        guiStyle.fontSize = 50; // Font size

        if (npcName == true && Camera.main.fieldOfView == 20f)
        {
            GUI.Label(new Rect(position.x - 105, Screen.height - position.y - 100, textSize.x, textSize.y), "Give food", guiStyle);
        }
    }
}
