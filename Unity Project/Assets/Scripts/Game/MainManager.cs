using System.Collections;
using System.Collections.Generic;
using System.Resources;
using TMPro;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public float playerResources;
    public bool isBuilt = false;

    public float Timer;
    public int DelayAmount = 1;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (Instance != null && isBuilt)
        {
            Timer += Time.deltaTime;

            if (Timer >= DelayAmount)
            {
                Timer = 0f;
                playerResources++;
            }
        }
    }
}
