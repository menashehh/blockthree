using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyHex2 : MonoBehaviour
{
    public GameObject TaskTextPrefab;
    private GameObject text;
    public int prefabLimit = 0;

    public GameObject HexButtonFly2;
    // private GUIStyle guiStyle = new GUIStyle();

    public int menuOpen = 0;

    private void Update()
    {
        if (menuOpen == 1 && Camera.main.fieldOfView <= 80f && !GameObject.Find("Grass Fly"))
        {
            HexButtonFly2.SetActive(true);
        }
        else HexButtonFly2.SetActive(false);

        if (!GameObject.Find("Background") && !GameObject.Find("Grass Fly") && Camera.main.fieldOfView <= 80f && menuOpen == 0)
        {
            if (prefabLimit != 1)
            {
                text = Instantiate(TaskTextPrefab, GameObject.Find("HexBuildFly2").transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity);
                prefabLimit++;
            }
        }
        else
        {
            Destroy(text);
            prefabLimit = 0;
        }
    }

    /*
    private void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(this.transform.position);
        var textSize = GUI.skin.label.CalcSize(new GUIContent("FlyHex2"));

        guiStyle.fontSize = 75;

        if (!GameObject.Find("Background") && !GameObject.Find("Grass Fly"))
        {
            if (Camera.main.fieldOfView <= 80f && menuOpen == 0)
            {
                GUI.Label(new Rect(position.x + 10, Screen.height - position.y - 100, textSize.x, textSize.y), "!", guiStyle);
            }
        }
    }
    */

    private void OnMouseDown()
    {
        if (Camera.main.fieldOfView <= 80f && !GameObject.Find("Background")
            && !GameObject.Find("wormText") && !GameObject.Find("Hex Button Worm") && !GameObject.Find("Hex Button Worm 2") && !GameObject.Find("Hex Button Worm 3") && !GameObject.Find("Hex Button Worm 4")
            && !GameObject.Find("frogText") && !GameObject.Find("Hex Button Frog") && !GameObject.Find("Hex Button Frog 2") && !GameObject.Find("Hex Button Frog 3")
            && !GameObject.Find("gooseText") && !GameObject.Find("Hex Button Goose")
            && !GameObject.Find("wolfText") && !GameObject.Find("Hex Button Wolf") && !GameObject.Find("Hex Button Wolf 2")
            && !GameObject.Find("sparrowText") && !GameObject.Find("Hex Button Sparrow") && !GameObject.Find("Hex Button Sparrow 2")
            && !GameObject.Find("buzzardText") && !GameObject.Find("Hex Button Buzzard") && !GameObject.Find("Hex Button Buzzard 2")
            && !GameObject.Find("beaverText") && !GameObject.Find("Hex Button Beaver")
            && !GameObject.Find("flyText") && !GameObject.Find("Hex Button Fly")
            && !GameObject.Find("beeText") && !GameObject.Find("Hex Button Bee"))
        {
            if (menuOpen == 0 && Camera.main.fieldOfView <= 80f)
            {
                menuOpen = 1;
                return;
            }

            if (menuOpen == 1 && Camera.main.fieldOfView <= 80f)
            {
                menuOpen = 0;
                return;
            }
        }
    }
}
