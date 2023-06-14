    using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class SparrowInteraction : MonoBehaviour
{
    // Script for the interactions with the sparrow (name, task, button)

    Highlight HighlightScript;

    public AudioSource sparrowSFX;

    public GameObject TaskTextPrefab;
    public GameObject AnimalLevelPrefab;

    public GameObject text;
    public GameObject text2;
    public int prefabLimit = 0;
    public int levelPrefabLimit = 0;

    public GameObject sparrowText;
    public TMP_Text sparrowLevel;
    public GameObject BuildButtonSparrow;

    public bool npcName = false;
    public int menuOpen = 0;

    // private GUIStyle guiStyle = new GUIStyle();

    private void Start()
    {
        HighlightScript = GetComponent<Highlight>();
    }

    private void OnMouseEnter()
    {
        if (GameObject.Find("LotCenter1").GetComponent<ButtonDown>().holdTimer <= 0.001 && Camera.main.fieldOfView <= 65f && !GameObject.Find("Background")
            && !GameObject.Find("wormText") && !GameObject.Find("Hex Button Worm") && !GameObject.Find("Hex Button Worm 2") && !GameObject.Find("Hex Button Worm 3") && !GameObject.Find("Hex Button Worm 4")
            && !GameObject.Find("frogText") && !GameObject.Find("Hex Button Frog") && !GameObject.Find("Hex Button Frog 2") && !GameObject.Find("Hex Button Frog 3")
            && !GameObject.Find("gooseText") && !GameObject.Find("Hex Button Goose")
            && !GameObject.Find("wolfText") && !GameObject.Find("Hex Button Wolf") && !GameObject.Find("Hex Button Wolf 2")
            && !GameObject.Find("Hex Button Sparrow") && !GameObject.Find("Hex Button Sparrow 2")
            && !GameObject.Find("buzzardText") && !GameObject.Find("Hex Button Buzzard") && !GameObject.Find("Hex Button Buzzard 2")
            && !GameObject.Find("beaverText") && !GameObject.Find("Hex Button Beaver")
            && !GameObject.Find("flyText") && !GameObject.Find("Hex Button Fly") && !GameObject.Find("Hex Button Fly 2")
            && !GameObject.Find("beeText") && !GameObject.Find("Hex Button Bee"))
        {
            sparrowText.SetActive(true);

            if (!GameObject.Find("Build Button Sparrow")) HighlightScript.ToggleHighlight(true);
        }
    }

    private void OnMouseUp()
    {
        if (!GameObject.Find("Background") && GameObject.Find("sparrowText") && !EventSystem.current.IsPointerOverGameObject())
        {
            if (menuOpen == 0 && Camera.main.fieldOfView <= 65f)
            {
                npcName = true;
                sparrowSFX.Play();

                if (Camera.main.GetComponent<CameraMechanicsRework>().cameraToggle == 1)
                {
                    Camera.main.transform.position = new Vector3(-10.06f, 0.23f, 5.65f);
                    ZoomInBool = true;
                }
            }

            if (menuOpen == 1 && Camera.main.fieldOfView <= 65f) npcName = false;

            if (menuOpen == 1) menuOpen = 0; else if (Camera.main.fieldOfView <= 65f) menuOpen++;

            HighlightScript.ToggleHighlight(false);
        }
    }

    private void OnMouseExit()
    {
        if (npcName == false)
        {
            sparrowText.SetActive(false);
            HighlightScript.ToggleHighlight(false);
        }
    }

    private bool ZoomInBool = false;
    private bool ZoomOutBool = false;
    private float velocity = 0f;
    private float smoothTime = 0.25f;

    private void Zoom(float fov)
    {
        Camera.main.fieldOfView = Mathf.SmoothDamp(Camera.main.fieldOfView, fov, ref velocity, smoothTime);
    }

    /*
    private void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(this.transform.position);
        var textSize = GUI.skin.label.CalcSize(new GUIContent("sparrowReq"));

        guiStyle.fontSize = 50;

        if (!GameObject.Find("Background") && sparrowLevel.text != "Level 4")
        {
            if (Camera.main.fieldOfView <= 65f && npcName == false)
            {
                guiStyle.fontSize = 75;
                GUI.Label(new Rect(position.x + 10, Screen.height - position.y - 210, textSize.x, textSize.y), "!", guiStyle);
            }
        }
    }
    */

    private void Update()
    {
        if (npcName == true && Camera.main.fieldOfView <= 65f && !GameObject.Find("Background"))
        {
            BuildButtonSparrow.SetActive(true);
        }
        else BuildButtonSparrow.SetActive(false);

        if (!GameObject.Find("Background") && GameObject.Find("sparrowText") && EventSystem.current.IsPointerOverGameObject() && EventSystem.current.currentSelectedGameObject != null &&
        EventSystem.current.currentSelectedGameObject.CompareTag("Close Buttons"))
        {
            sparrowText.SetActive(false);
            npcName = false;
            menuOpen = 0;
            ZoomOutBool = true;
        }

        if (ZoomInBool == true)
        {
            Zoom(20);
            if ((Camera.main.fieldOfView >= 19 && Camera.main.fieldOfView <= 21) || ZoomOutBool == true)
            {
                ZoomInBool = false;
            }
        }

        if (ZoomOutBool == true)
        {
            Zoom(45);
            if ((Camera.main.fieldOfView >= 44 && Camera.main.fieldOfView <= 46) || ZoomInBool == true)
            {
                ZoomOutBool = false;
            }
        }

        if (!GameObject.Find("Background") && sparrowLevel.text != "Level 4" && Camera.main.fieldOfView <= 65f && npcName == false)
        {
            if (prefabLimit != 1)
            {
                text = Instantiate(TaskTextPrefab, GameObject.Find("Sparrow").transform.position + new Vector3(0f, 1.5f, 0f), Quaternion.identity);
                prefabLimit++;
            }
        }
        else
        {
            Destroy(text);
            prefabLimit = 0;
        }

        if (!GameObject.Find("Background") && Camera.main.fieldOfView <= 65f)
        {
            if (levelPrefabLimit != 1)
            {
                text2 = Instantiate(AnimalLevelPrefab, GameObject.Find("Sparrow").transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity);
                text2.GetComponent<TMPro.TextMeshPro>().SetText(sparrowLevel.text);
                levelPrefabLimit++;
            }
        }
        else
        {
            Destroy(text2);
            levelPrefabLimit = 0;
        }
    }
}
