using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RocketUI : MonoBehaviour
{
    public RocketControl rocket;
    public Slider thrustSlider;
    

    void Update()
    {
        thrustSlider.value = rocket.currentThrust / rocket.maxThrust;
       
    }
}
