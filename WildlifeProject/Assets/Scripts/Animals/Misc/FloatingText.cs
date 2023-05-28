using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingText : MonoBehaviour
{
    public float DestroyTime = 0.5f; // CHANGE IN INSPECTOR

    void Start()
    {
        Destroy(gameObject, DestroyTime);
    }
}
