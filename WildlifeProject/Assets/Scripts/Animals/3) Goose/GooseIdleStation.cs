using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GooseIdleStation : MonoBehaviour
{
    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    public TMP_Text gooseLevel;
    public GameObject FloatingTextPrefab;

    public float Timer;
    public int DelayAmount = 1;

    private void Awake()
    {
        resourceCountScript = resourceCountObject.GetComponent<ResourceCount>();
    }

    // TAP INCOME

    private void OnMouseDown()
    {
        if (Camera.main.fieldOfView <= 80f && !GameObject.Find("Background"))
        {
            if (gooseLevel.text == "Level 1")
            {
                resourceCountScript.resources += 1.7f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Goose Station").transform.position + new Vector3(0f, 1.3f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+1.7");
                }
            }

            if (gooseLevel.text == "Level 2")
            {
                resourceCountScript.resources += 2.7f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Goose Station").transform.position + new Vector3(0f, 1.3f, 0f), Quaternion.identity);
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
            if (gooseLevel.text == "Level 2")
            {
                resourceCountScript.resources += 1.5f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Goose Station").transform.position + new Vector3(0f, 1.3f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+1.5");
                }
            }

            Timer = 0f;
        }
    }
}
