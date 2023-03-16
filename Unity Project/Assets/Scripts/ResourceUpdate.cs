using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ResourceUpdate : MonoBehaviour
{
    public TMP_Text resourceText;
    private float resources;
    public int DelayAmount = 1;

    protected float Timer;

    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= DelayAmount)
        {
            Timer = 0f;
            resources++;
            resourceText.text = "Resources  " + resources;
        }
    }


    private void OnMouseDown()
    {
        if (Camera.main.fieldOfView == 20f)
        {
            AddResource();
        }
    }

    public void AddResource()
    {
        resources++;
        resourceText.text = "Resources  " + resources;
    }
}
