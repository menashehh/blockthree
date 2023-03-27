using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NpcUI : MonoBehaviour
{
   void OnMouseDown()
    {
        if (Camera.main.fieldOfView == 40f)
        {
            Debug.Log("NPC Click");
        }
    }
}
    