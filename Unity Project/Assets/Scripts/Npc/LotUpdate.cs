using System.Collections;
using System.Collections.Generic;
using System.Resources;
using TMPro;
using UnityEngine;

public class LotUpdate : MonoBehaviour
{
    public TMP_Text LotsCount;
    public int lotsCount;

    private void Awake()
    {
        if (MainManager.Instance != null)
        {
            lotsCount = MainManager.Instance.playerLots;
        }

        lotsCount = 1;
    }

    private void Update()
    {
        MainManager.Instance.playerLots = lotsCount;

        if (GameObject.Find("worm")) lotsCount = 2;
        if (GameObject.Find("wolf")) lotsCount = 3;

        LotsCount.text = "" + lotsCount;
    }
}
