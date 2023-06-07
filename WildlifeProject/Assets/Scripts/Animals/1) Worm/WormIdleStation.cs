using System.Collections;
using System.Collections.Generic;
using System.Resources;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class WormIdleStation : MonoBehaviour
{
    Highlight HighlightScript;

    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    public TMP_Text wormLevel;
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
            if (wormLevel.text == "Level 2")
            {
                resourceCountScript.resources += 1f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Wheelbarrow").transform.position + new Vector3(-1.3f, 2.4f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+1");
                }
            }

            if (wormLevel.text == "Level 3")
            {
                resourceCountScript.resources += 2f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Wheelbarrow").transform.position + new Vector3(-1.3f, 2.4f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+2");
                }
            }

            if (wormLevel.text == "Level 4")
            {
                resourceCountScript.resources += 4f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Wheelbarrow").transform.position + new Vector3(-1.3f, 2.4f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+4");
                }
            }

            if (wormLevel.text == "Level 5")
            {
                resourceCountScript.resources += 6f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Wheelbarrow").transform.position + new Vector3(-1.3f, 2.4f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+6");
                }
            }

            if (wormLevel.text == "Level 6")
            {
                resourceCountScript.resources += 12f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Wheelbarrow").transform.position + new Vector3(-1.3f, 2.4f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+12");
                }
            }

            if (wormLevel.text == "Level 7")
            {
                resourceCountScript.resources += 36f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Wheelbarrow").transform.position + new Vector3(-1.3f, 2.4f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+36");
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
            if (wormLevel.text == "Level 3")
            {
                resourceCountScript.resources += 1f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Wheelbarrow").transform.position + new Vector3(-1.3f, 2.4f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+1");
                }
            }

            if (wormLevel.text == "Level 4")
            {
                resourceCountScript.resources += 2f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Wheelbarrow").transform.position + new Vector3(-1.3f, 2.4f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+2");
                }
            }

            if (wormLevel.text == "Level 5")
            {
                resourceCountScript.resources += 4f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Wheelbarrow").transform.position + new Vector3(-1.3f, 2.4f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+4");
                }
            }

            if (wormLevel.text == "Level 6")
            {
                resourceCountScript.resources += 16f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Wheelbarrow").transform.position + new Vector3(-1.3f, 2.4f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+16");
                }
            }

            if (wormLevel.text == "Level 7")
            {
                resourceCountScript.resources += 55f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Wheelbarrow").transform.position + new Vector3(-1.3f, 2.4f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+55");
                }
            }

            Timer = 0f;
        }
    }
}
