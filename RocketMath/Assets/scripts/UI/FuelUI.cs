using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelUI : MonoBehaviour
{
    public Slider fuelSlider;
    public RocketControl rocket;

    public Image sliderFill;
    public Text warningText;
   

    void Update()
    {
        if (rocket != null)
        {
            fuelSlider.value = rocket.fuel;
        }

        fuelSlider.value = rocket.fuel;

        if (rocket.fuel > 50)
            sliderFill.color = Color.green;
        else if (rocket.fuel > 20)
            sliderFill.color = Color.yellow;
        else sliderFill.color = Color.red;
        
        warningText.enabled = rocket.fuel < 20 && rocket.fuel > 0;
    }
}
