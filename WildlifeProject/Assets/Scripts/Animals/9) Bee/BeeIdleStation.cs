using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class BeeIdleStation : MonoBehaviour
{
    Highlight HighlightScript;

    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    public TMP_Text beeLevel;
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
            if (beeLevel.text == "Level 1")
            {
                resourceCountScript.resources += 35f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Bee Station").transform.position + new Vector3(0f, 1.7f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+35");
                }
            }

            if (beeLevel.text == "Level 2")
            {
                resourceCountScript.resources += 56f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Bee Station").transform.position + new Vector3(0f, 1.7f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+56");
                }
            }

            if (beeLevel.text == "Level 3")
            {
                resourceCountScript.resources += 90f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Bee Station").transform.position + new Vector3(0f, 1.7f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+90");
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
            if (beeLevel.text == "Level 2")
            {
                resourceCountScript.resources += 56f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Bee Station").transform.position + new Vector3(0f, 1.7f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+56");
                }
            }

            if (beeLevel.text == "Level 3")
            {
                resourceCountScript.resources += 132f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Bee Station").transform.position + new Vector3(0f, 1.7f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+132");
                }
            }

            Timer = 0f;
        }
    }
}
