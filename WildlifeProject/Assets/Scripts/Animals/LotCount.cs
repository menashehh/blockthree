using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LotCount : MonoBehaviour
{
    public TMP_Text LotsCount;
    public int lotsCount = 1;

    private void Update()
    {
        LotsCount.text = "" + lotsCount;
    }
}
