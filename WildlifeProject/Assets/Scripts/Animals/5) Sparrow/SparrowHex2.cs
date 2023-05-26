using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparrowHex2 : MonoBehaviour
{
    public GameObject HexButtonSparrow2;
    private GUIStyle guiStyle = new GUIStyle();

    public int menuOpen = 0;

    private void Update()
    {
        if (menuOpen == 1 && Camera.main.fieldOfView == 80f && !GameObject.Find("Grass Sparrow"))
        {
            HexButtonSparrow2.SetActive(true);
        }
        else HexButtonSparrow2.SetActive(false);
    }

    private void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(this.transform.position);
        var textSize = GUI.skin.label.CalcSize(new GUIContent("SparrowHex2"));

        guiStyle.fontSize = 75;

        if (!GameObject.Find("Background") && !GameObject.Find("Grass Sparrow"))
        {
            if (Camera.main.fieldOfView == 80f && menuOpen == 0)
            {
                GUI.Label(new Rect(position.x + 10, Screen.height - position.y - 100, textSize.x, textSize.y), "!", guiStyle);
            }
        }
    }

    private void OnMouseDown()
    {
        if (Camera.main.fieldOfView == 80f && !GameObject.Find("Background")
            && !GameObject.Find("wormText") && !GameObject.Find("Hex Button Worm") && !GameObject.Find("Hex Button Worm 2") && !GameObject.Find("Hex Button Worm 3") && !GameObject.Find("Hex Button Worm 4")
            && !GameObject.Find("frogText") && !GameObject.Find("Hex Button Frog") && !GameObject.Find("Hex Button Frog 2") && !GameObject.Find("Hex Button Frog 3")
            && !GameObject.Find("gooseText") && !GameObject.Find("Hex Button Goose")
            && !GameObject.Find("wolfText") && !GameObject.Find("Hex Button Wolf") && !GameObject.Find("Hex Button Wolf 2")
            && !GameObject.Find("sparrowText") && !GameObject.Find("Hex Button Sparrow")
            && !GameObject.Find("buzzardText") && !GameObject.Find("Hex Button Buzzard") && !GameObject.Find("Hex Button Buzzard 2")
            && !GameObject.Find("beaverText") && !GameObject.Find("Hex Button Beaver")
            && !GameObject.Find("flyText") && !GameObject.Find("Hex Button Fly") && !GameObject.Find("Hex Button Fly 2")
            && !GameObject.Find("beeText") && !GameObject.Find("Hex Button Bee"))
        {
            if (menuOpen == 0 && Camera.main.fieldOfView == 80f)
            {
                menuOpen = 1;
                return;
            }

            if (menuOpen == 1 && Camera.main.fieldOfView == 80f)
            {
                menuOpen = 0;
                return;
            }
        }
    }
}
