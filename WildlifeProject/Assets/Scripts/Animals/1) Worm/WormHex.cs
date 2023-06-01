using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;

public class WormHex : MonoBehaviour
{
    public GameObject TaskTextPrefab;
    private GameObject text;
    public int prefabLimit = 0;

    public GameObject HexButtonWorm;
    // private GUIStyle guiStyle = new GUIStyle();

    public int menuOpen = 0;

    private void Update()
    {
        if (menuOpen == 1 && Camera.main.fieldOfView <= 80f && !GameObject.Find("Apple"))
        {
            HexButtonWorm.SetActive(true);
        }
        else HexButtonWorm.SetActive(false);

        if (Camera.main.fieldOfView <= 80f && !GameObject.Find("Background") && EventSystem.current.IsPointerOverGameObject() && EventSystem.current.currentSelectedGameObject != null &&
        EventSystem.current.currentSelectedGameObject.CompareTag("Close Buttons")) menuOpen = 0;

        if (!GameObject.Find("Background") && !GameObject.Find("Apple") && Camera.main.fieldOfView <= 80f && menuOpen == 0)
        {
            if (prefabLimit != 1)
            {
                text = Instantiate(TaskTextPrefab, GameObject.Find("HexBuildWorm").transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity);
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
        var textSize = GUI.skin.label.CalcSize(new GUIContent("WormHex"));

        guiStyle.fontSize = 75;

        if (!GameObject.Find("Background") && !GameObject.Find("Apple"))
        {
            if (Camera.main.fieldOfView <= 80f && menuOpen == 0)
            {
                GUI.Label(new Rect(position.x + 10, Screen.height - position.y - 100, textSize.x, textSize.y), "!", guiStyle);
            }
        }
    }
    */

    private void OnMouseUp()
    {
        if (Camera.main.fieldOfView <= 80f && !GameObject.Find("Background") && !EventSystem.current.IsPointerOverGameObject()
            && !GameObject.Find("wormText") && !GameObject.Find("Hex Button Worm 2") && !GameObject.Find("Hex Button Worm 3") && !GameObject.Find("Hex Button Worm 4")
            && !GameObject.Find("frogText") && !GameObject.Find("Hex Button Frog") && !GameObject.Find("Hex Button Frog 2") && !GameObject.Find("Hex Button Frog 3")
            && !GameObject.Find("gooseText") && !GameObject.Find("Hex Button Goose")
            && !GameObject.Find("wolfText") && !GameObject.Find("Hex Button Wolf") && !GameObject.Find("Hex Button Wolf 2")
            && !GameObject.Find("sparrowText") && !GameObject.Find("Hex Button Sparrow") && !GameObject.Find("Hex Button Sparrow 2")
            && !GameObject.Find("buzzardText") && !GameObject.Find("Hex Button Buzzard") && !GameObject.Find("Hex Button Buzzard 2")
            && !GameObject.Find("beaverText") && !GameObject.Find("Hex Button Beaver")
            && !GameObject.Find("flyText") && !GameObject.Find("Hex Button Fly") && !GameObject.Find("Hex Button Fly 2")
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
