using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ResourceUpdate : MonoBehaviour
{
    public TMP_Text resourceText;
    public float resources;
    public int DelayAmount = 1;

    public float Timer;

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

        resourceText.text = "" + resources;
    }


    private void OnMouseDown()
    {
        if (Camera.main.fieldOfView == 40f)
        {
            AddResource();
        }
    }

    public void AddResource()
    {
        resources++;
        resourceText.text = "" + resources;
    }
}
