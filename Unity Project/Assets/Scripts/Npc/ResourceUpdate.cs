using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ResourceUpdate : MonoBehaviour
{
    public TMP_Text resourceText;
    public float resources;
    public GameObject FloatingTextPrefab;
    public int DelayAmount = 1;

    public float Timer;

    public bool stationActive = false;

    private void Start()
    {
        if (MainManager.Instance != null)
        {
            resources = MainManager.Instance.playerResources;
        }
    }

    private void Update()
    {
        /*
        Timer += Time.deltaTime;

        if (Timer >= DelayAmount)
        {
            Timer = 0f;
            resources++;
        }
        resourceText.text = "" + resources;
        */

        MainManager.Instance.playerResources = resources;

        if (stationActive)
        {
            MainManager.Instance.isBuilt = true;
        }

        resourceText.text = "" + resources;
    }


    private void OnMouseDown()
    {
        if (Camera.main.fieldOfView == 40f)
        {
            AddResource();
            if (FloatingTextPrefab != null) ShowFloatingText();
        }
    }

    public void AddResource()
    {
        resources++;
        resourceText.text = "" + resources;
    }

    public void ShowFloatingText()
    {
        var text = Instantiate(FloatingTextPrefab, transform.position + new Vector3 (0f, 1f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+1");
    }

    public void ShowFloatingText1()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Flower").transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+1");
    }

    public void ShowFloatingText2()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("appleTree").transform.position + new Vector3(0f, 2f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+2");
    }


    public void ShowFloatingText4()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("wolfHouse").transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+4");
    }

}
