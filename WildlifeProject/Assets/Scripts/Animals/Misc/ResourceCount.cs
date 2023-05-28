using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourceCount : MonoBehaviour
{
    public TMP_Text resourceText;
    public float resources;

    private void Update()
    {
        resourceText.text = "" + resources.ToString("n1", System.Globalization.CultureInfo.CreateSpecificCulture("de-DE"));
    }
}
