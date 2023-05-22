using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ResourceUpdate : MonoBehaviour
{
    // Main resource update script that is used for the worm

    public TMP_Text resourceText;
    public GameObject FloatingTextPrefab;

    public float resources = 0;
    public float Timer;
    public int DelayAmount = 1;

    private void OnMouseDown()
    {
        if (Camera.main.fieldOfView == 80f && !GameObject.Find("Background"))
        {
            AddResourceWorm();
        }
    }

    // ADD RESOURCE
        // ANIMALS

    public void AddResourceWorm()
    {
        resources++;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingTextWorm();
    }

    public void AddResourceFrog()
    {
        resources++;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingTextFrog();
    }

    public void AddResourceGoose()
    {
        resources++;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingTextGoose();
    }

    public void AddResourceWolf()
    {
        resources++;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingTextWolf();
    }

    public void AddResourceSparrow()
    {
        resources++;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingTextSparrow();
    }

    public void AddResourceBuzzard()
    {
        resources++;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingTextBuzzard();
    }

    public void AddResourceBeaver()
    {
        resources++;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingTextBeaver();
    }

    public void AddResourceFly()
    {
        resources++;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingTextFly();
    }

    public void AddResourceBee()
    {
        resources++;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingTextBee();
    }

        // STATIONS

    public void AddResourceAppleTree()
    {
        resources += 1;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingText1();
    }

    public void AddResourceFlower()
    {
        resources += 2;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingText2();
    }

    public void AddResourceGooseS()
    {
        resources += 4;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingText4();
    }

    public void AddResourceWolfHouse()
    {
        resources += 8;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingText8();
    }

    public void AddResourceSparrowS()
    {
        resources += 3;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingText3();
    }

    public void AddResourceBuzzardS()
    {
        resources += 5;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingText5();
    }

    public void AddResourceBeaverS()
    {
        resources += 7;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingText7();
    }

    public void AddResourceFlyS()
    {
        resources += 9;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingText9();
    }

    public void AddResourceBeeS()
    {
        resources += 11;
        resourceText.text = "" + resources;
        if (FloatingTextPrefab != null) ShowFloatingText11();
    }

    // SHOW FLOATING TEXT
    // ANIMALS

    public void ShowFloatingTextWorm()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Worm").transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+1");
    }

    public void ShowFloatingTextFrog()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Frog").transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+1");
    }

    public void ShowFloatingTextGoose()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Goose").transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+1");
    }

    public void ShowFloatingTextWolf()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Wolf").transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+1");
    }

    public void ShowFloatingTextSparrow()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Sparrow").transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+1");
    }

    public void ShowFloatingTextBuzzard()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Buzzard").transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+1");
    }

    public void ShowFloatingTextBeaver()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Beaver").transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+1");
    }

    public void ShowFloatingTextFly()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Fly").transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+1");
    }

    public void ShowFloatingTextBee()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Bee").transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+1");
    }

        // STATIONS

    public void ShowFloatingText1()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Apple Tree").transform.position + new Vector3(0f, 2.5f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+1");
    }

    public void ShowFloatingText2()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Flower").transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+2");
    }


    public void ShowFloatingText4()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Goose Station").transform.position + new Vector3(0f, 1.5f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+4");
    }

    public void ShowFloatingText8()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Wolf House").transform.position + new Vector3(0f, 1.5f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+8");
    }

    public void ShowFloatingText3()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Sparrow Station").transform.position + new Vector3(0f, 1.5f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+3");
    }

    public void ShowFloatingText5()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Buzzard Station").transform.position + new Vector3(0f, 1.5f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+5");
    }

    public void ShowFloatingText7()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Beaver Station").transform.position + new Vector3(0f, 1.5f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+7");
    }

    public void ShowFloatingText9()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Fly Station").transform.position + new Vector3(0f, 1.5f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+9");
    }

    public void ShowFloatingText11()
    {
        var text = Instantiate(FloatingTextPrefab, GameObject.Find("Bee Station").transform.position + new Vector3(0f, 1.5f, 0f), Quaternion.identity, transform);
        text.GetComponent<TMPro.TextMeshPro>().SetText("+11");
    }
}
