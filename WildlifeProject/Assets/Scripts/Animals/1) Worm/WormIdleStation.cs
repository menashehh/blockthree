using System.Collections;
using System.Collections.Generic;
using System.Resources;
using TMPro;
using UnityEngine;

public class WormIdleStation : MonoBehaviour
{
    ResourceCount resourceCountScript;
    public GameObject resourceCountObject;

    public TMP_Text wormLevel;
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
            if (wormLevel.text == "Level 2")
            {
                resourceCountScript.resources += 1.7f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Apple Tree").transform.position + new Vector3(0f, 2.1f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+1.7");
                }
            }

            if (wormLevel.text == "Level 3")
            {
                resourceCountScript.resources += 2.7f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Apple Tree").transform.position + new Vector3(0f, 2.1f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+2.7");
                }
            }

            if (wormLevel.text == "Level 4")
            {
                resourceCountScript.resources += 3.7f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Apple Tree").transform.position + new Vector3(0f, 2.1f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+3.7");
                }
            }

            if (wormLevel.text == "Level 5")
            {
                resourceCountScript.resources += 4.7f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Apple Tree").transform.position + new Vector3(0f, 2.1f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+4.7");
                }
            }

            if (wormLevel.text == "Level 6")
            {
                resourceCountScript.resources += 5.7f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Apple Tree").transform.position + new Vector3(0f, 2.1f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+5.7");
                }
            }

            if (wormLevel.text == "Level 7")
            {
                resourceCountScript.resources += 6.7f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Apple Tree").transform.position + new Vector3(0f, 2.1f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+6.7");
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
                resourceCountScript.resources += 1.5f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Apple Tree").transform.position + new Vector3(0f, 2.1f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+1.5");
                }
            }

            if (wormLevel.text == "Level 4")
            {
                resourceCountScript.resources += 2.5f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Apple Tree").transform.position + new Vector3(0f, 2.1f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+2.5");
                }
            }

            if (wormLevel.text == "Level 5")
            {
                resourceCountScript.resources += 3f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Apple Tree").transform.position + new Vector3(0f, 2.1f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+3");
                }
            }

            if (wormLevel.text == "Level 6")
            {
                resourceCountScript.resources += 3.5f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Apple Tree").transform.position + new Vector3(0f, 2.1f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+3.5");
                }
            }

            if (wormLevel.text == "Level 7")
            {
                resourceCountScript.resources += 4f;

                if (FloatingTextPrefab != null)
                {
                    var text = Instantiate(FloatingTextPrefab, GameObject.Find("Apple Tree").transform.position + new Vector3(0f, 2.1f, 0f), Quaternion.identity);
                    text.GetComponent<TMPro.TextMeshPro>().SetText("+4");
                }
            }

            Timer = 0f;
        }
    }
}
