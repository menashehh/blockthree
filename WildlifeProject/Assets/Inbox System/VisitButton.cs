using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class VisitButton : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private string linkToOpen;

    private void OnEnable()
    {
        button.onClick.AddListener(OpenLink);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(OpenLink);
    }

    private void OpenLink()
    {
        Application.OpenURL("http://unity3d.com/");
    }

}
