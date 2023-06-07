using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class SparrowIdleStation : MonoBehaviour
{
    Highlight HighlightScript;

    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    public TMP_Text sparrowLevel;
    public GameObject FloatingTextPrefab;

    public float Timer;
    public int DelayAmount = 1;

    private void Awake()
    {
        resourceCountScript = resourceCountObject.GetComponent<ResourceCount>();
        HighlightScript = GetComponent<Highlight>();
    }

    // TAP INCOME

    private void OnMouseEnter()
    {
        if (Camera.main.fieldOfView <= 80f && GameObject.Find("LotCenter1").GetComponent<ButtonDown>().holdTimer <= 0.001 && !EventSystem.current.IsPointerOverGameObject()) HighlightScript.ToggleHighlight(true);
    }

    private void OnMouseExit()
    {
        HighlightScript.ToggleHighlight(false);
    }

    private void OnMouseUp()
    {
        if (Camera.main.fieldOfView <= 80f && !GameObject.Find("Background") && !EventSystem.current.IsPointerOverGameObject())
        {
            if (sparrowLevel.text == "Level 1")
            {
                resourceCountScript.resources += 8f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Sparrow Station").transform.position + new Vector3(0f, 1.3f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+8");
                }
            }

            if (sparrowLevel.text == "Level 2")
            {
                resourceCountScript.resources += 15f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Sparrow Station").transform.position + new Vector3(0f, 1.3f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+15");
                }
            }

            if (sparrowLevel.text == "Level 3")
            {
                resourceCountScript.resources += 20f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Sparrow Station").transform.position + new Vector3(0f, 1.3f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+20");
                }
            }

            if (sparrowLevel.text == "Level 4")
            {
                resourceCountScript.resources += 30f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Sparrow Station").transform.position + new Vector3(0f, 1.3f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+30");
                }
            }
        }
    }

    // AFK INCOME
    private void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= DelayAmount)
        {
            if (sparrowLevel.text == "Level 2")
            {
                resourceCountScript.resources += 16f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Sparrow Station").transform.position + new Vector3(0f, 1.3f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+16");
                }
            }

            if (sparrowLevel.text == "Level 3")
            {
                resourceCountScript.resources += 26f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Sparrow Station").transform.position + new Vector3(0f, 1.3f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+26");
                }
            }

            if (sparrowLevel.text == "Level 4")
            {
                resourceCountScript.resources += 40f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Sparrow Station").transform.position + new Vector3(0f, 1.3f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+40");
                }
            }

            Timer = 0f;
        }
    }
}
