using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DistanceCalc : MonoBehaviour
{
    public Transform rocket;
    public Transform target;
    public TMP_Text distanceText;
    public TMP_Text targetText;
    public float targetDistance = 1.0f;

    private float currentDistance;
    
    void Update()
    {
        float dx = target.position.x - rocket.position.x;
        float dy = target.position.y - rocket.position.y;
        currentDistance = Mathf.Sqrt(dx * dx + dy * dy);

        distanceText.text = $"Distance to target: {currentDistance:F2} m";
        targetText.text = $"Target: {target.name}";

        if (currentDistance <= targetDistance)
        {
            distanceText.text = "Target reached";
            OnTargetReached();
        }
    }

    void OnTargetReached()
    {
        Debug.Log("Rocket found target");
    }
}
