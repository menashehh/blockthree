using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LotCount : MonoBehaviour
{
    public TMP_Text LotsCount;
    public int lotsCount = 1; // CHANGE FROM INSPECTOR

    private void Update()
    {
        LotsCount.text = lotsCount + "/15";
    }
}
