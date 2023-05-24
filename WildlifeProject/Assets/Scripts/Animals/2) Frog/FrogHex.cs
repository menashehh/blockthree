using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogHex : MonoBehaviour
{
    public GameObject HexButtonFrog;
    private GUIStyle guiStyle = new GUIStyle();

    public int menuOpen = 0;

    private void Update()
    {
        if (menuOpen == 1 && Camera.main.fieldOfView <= 60f && !GameObject.Find("waterFrog"))
        {
            HexButtonFrog.SetActive(true);
        }
        else HexButtonFrog.SetActive(false);
    }

    private void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(this.transform.position);
        var textSize = GUI.skin.label.CalcSize(new GUIContent("FrogHex"));

        guiStyle.fontSize = 75;

        if (!GameObject.Find("Background") && !GameObject.Find("waterFrog"))
        {
            if (Camera.main.fieldOfView <= 60f && menuOpen == 0)
            {
                GUI.Label(new Rect(position.x + 10, Screen.height - position.y - 100, textSize.x, textSize.y), "!", guiStyle);
            }
        }
    }

    private void OnMouseDown()
    {
        if (!GameObject.Find("Background") && !GameObject.Find("wormText") && !GameObject.Find("Hex Button Worm") && !GameObject.Find("frogText") && !GameObject.Find("gooseText") && !GameObject.Find("wolfText") && !GameObject.Find("Hex Button Wolf") && !GameObject.Find("sparrowText") && !GameObject.Find("buzzardText") && !GameObject.Find("Hex Button Buzzard") && !GameObject.Find("beaverText") && !GameObject.Find("flyText") && !GameObject.Find("Hex Button Fly") && !GameObject.Find("beeText"))
        {
            if (menuOpen == 0 && Camera.main.fieldOfView <= 60f)
            {
                menuOpen = 1;
                return;
            }

            if (menuOpen == 1 && Camera.main.fieldOfView <= 60f)
            {
                menuOpen = 0;
                return;
            }
        }
    }
}
