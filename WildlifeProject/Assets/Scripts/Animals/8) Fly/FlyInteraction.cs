using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class FlyInteraction : MonoBehaviour
{
    // Script for the interactions with the fly (name, task, button)

    Highlight HighlightScript;

    public AudioSource flySFX;

    public GameObject TaskTextPrefab;
    public GameObject AnimalLevelPrefab;

    public GameObject text;
    public GameObject text2;
    public int prefabLimit = 0;
    public int levelPrefabLimit = 0;

    public GameObject flyText;
    public TMP_Text flyLevel;
    public GameObject BuildButtonFly;

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
             && !GameObject.Find("sparrowText") && !GameObject.Find("Hex Button Sparrow") && !GameObject.Find("Hex Button Sparrow 2")
             && !GameObject.Find("buzzardText") && !GameObject.Find("Hex Button Buzzard") && !GameObject.Find("Hex Button Buzzard 2")
             && !GameObject.Find("beaverText") && !GameObject.Find("Hex Button Beaver")
             && !GameObject.Find("Hex Button Fly") && !GameObject.Find("Hex Button Fly 2")
             && !GameObject.Find("beeText") && !GameObject.Find("Hex Button Bee"))
        {
            flyText.SetActive(true);

            if (!GameObject.Find("Build Button Fly")) HighlightScript.ToggleHighlight(true);
        }
    }

    private void OnMouseUp()
    {
        if (!GameObject.Find("Background") && GameObject.Find("flyText") && !EventSystem.current.IsPointerOverGameObject())
        {
            if (menuOpen == 0 && Camera.main.fieldOfView <= 65f)
            {
                npcName = true;
                flySFX.Play();

                if (Camera.main.GetComponent<CameraMechanicsRework>().cameraToggle == 1)
                {
                    Camera.main.transform.position = new Vector3(-5.08f, 0.23f, 7.64f);
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
            flyText.SetActive(false);
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
        var textSize = GUI.skin.label.CalcSize(new GUIContent("flyReq"));

        guiStyle.fontSize = 50;

        if (!GameObject.Find("Background") && flyLevel.text != "Level 3")
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
            BuildButtonFly.SetActive(true);
        }
        else BuildButtonFly.SetActive(false);

        if (!GameObject.Find("Background") && GameObject.Find("flyText") && EventSystem.current.IsPointerOverGameObject() && EventSystem.current.currentSelectedGameObject != null &&
        EventSystem.current.currentSelectedGameObject.CompareTag("Close Buttons"))
        {
            flyText.SetActive(false);
            npcName = false;
            menuOpen = 0;
            ZoomOutBool = true;
        }

        if (ZoomInBool == true)
        {
            Zoom(15);
            if ((Camera.main.fieldOfView >= 9 && Camera.main.fieldOfView <= 11) || ZoomOutBool == true)
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

        if (!GameObject.Find("Background") && flyLevel.text != "Level 3" && Camera.main.fieldOfView <= 65f && npcName == false)
        {
            if (prefabLimit != 1)
            {
                text = Instantiate(TaskTextPrefab, GameObject.Find("Fly").transform.position + new Vector3(0f, 2.2f, 0f), Quaternion.identity);
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
                text2 = Instantiate(AnimalLevelPrefab, GameObject.Find("Fly").transform.position + new Vector3(0f, 1.7f, 0f), Quaternion.identity);
                text2.GetComponent<TMPro.TextMeshPro>().SetText(flyLevel.text);
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
