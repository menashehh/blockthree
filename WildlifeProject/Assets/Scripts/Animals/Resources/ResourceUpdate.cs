using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ResourceUpdate : MonoBehaviour
{
    // Main resource update script that is used for the frog

    public TMP_Text resourceText;
    public GameObject FloatingTextPrefab;

    public float resources;
    public float Timer;
    public int DelayAmount = 1;
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
            AddResourceFrog();
        }
    }

    public void AddResourceFrog()
    {
        resources++;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingTextFrog();
    }

    public void AddResourceWorm()
    {
        resources++;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingTextWorm();
    }

    public void AddResourceWolf()
    {
        resources++;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingTextWolf();
    }

    public void AddResourceFlower()
    {
        resources++;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingText1();
    }

    public void AddResourceAppleTree()
    {
        resources += 2;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingText2();
    }

    public void AddResourceWolfHouse()
    {
        resources += 4;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingText4();
    }

    public void ShowFloatingTextFrog()
    {
        var text = Instantiate(FloatingTextPrefab, transform.position + new Vector3 (0f, 1f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+1");
    }

    public void ShowFloatingTextWorm()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Worm").transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+1");
    }

    public void ShowFloatingTextWolf()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Wolf").transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+1");
    }

    public void ShowFloatingText1()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Flower").transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+1");
    }

    public void ShowFloatingText2()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Apple Tree").transform.position + new Vector3(0f, 2.5f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+2");
    }


    public void ShowFloatingText4()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Wolf House").transform.position + new Vector3(0f, 1.5f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+4");
    }

}
