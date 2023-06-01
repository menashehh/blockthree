using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine;

public class WolfIdleStation : MonoBehaviour
{
    Highlight HighlightScript;

    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    public TMP_Text wolfLevel;
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
            if (wolfLevel.text == "Level 2")
            {
                resourceCountScript.resources += 1.7f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Wolf House").transform.position + new Vector3(0f, 1.3f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+1.7");
                }
            }

            if (wolfLevel.text == "Level 3")
            {
                resourceCountScript.resources += 2.7f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Wolf House").transform.position + new Vector3(0f, 1.3f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+2.7");
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
            if (wolfLevel.text == "Level 3")
            {
                resourceCountScript.resources += 1.5f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Wolf House").transform.position + new Vector3(0f, 1.3f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+1.5");
                }
            }

            Timer = 0f;
        }
    }
}
