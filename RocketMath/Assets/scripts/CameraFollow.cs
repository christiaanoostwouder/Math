using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform rocket; // De raket die gevolgd moet worden
    public Vector3 offset;   // De afstand tussen de camera en de raket

    void LateUpdate()
    {
        if (rocket != null)
        {
            // Volg alleen de positie van de raket met de offset
            transform.position = rocket.position + offset;
        }
    }
}
