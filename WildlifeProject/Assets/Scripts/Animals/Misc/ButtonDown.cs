using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ButtonDown : MonoBehaviour
{
    public float holdTimer;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            holdTimer += Time.deltaTime;
        }
        else holdTimer = 0f;
    }
}
