using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.WSA;
using TMPro;

public class FuelRatio : MonoBehaviour
{
    public Slider oxygenSlider;
    public Slider hydrogenSlider;
    public TMP_Text feedbackText;
    public float totalfuel = 10f;

    private float correctOxygenRatio = 3f / 5f;
    private float correctHydrogenRatio = 2f / 5f;
    public GameObject rocket;
    private RocketControl rocketControl;

    private void Start()
    {
        rocketControl = rocket.GetComponent<RocketControl>();

        if (rocketControl != null )
        {
            rocketControl.enabled = false;
        }
    }

    public void CheckFuel()
    {
        float oxygenAmount = oxygenSlider.value * totalfuel;
        float hydrogenAmount = hydrogenSlider.value * totalfuel;

        //calculate ratio
        float oxygenRatio = oxygenAmount / totalfuel;
        float hydrogenRatio = hydrogenAmount / totalfuel;

        //check if ratio correct
        if (Mathf.Approximately(oxygenRatio, correctOxygenRatio) && Mathf.Approximately(hydrogenRatio, correctHydrogenRatio))
        {
            feedbackText.text = "The Ratio is right";
            LaunchRocket();
        }
        else
        {
            feedbackText.text = "Ratio is Not right";
            if (rocketControl != null)
            {
                rocketControl.enabled = false;
            }
        }
    }

    private void LaunchRocket()
    {
        Debug.Log("Rocket is Launched");
        if (rocketControl != null)
        {
            rocketControl.enabled = true;
        }
    }

}
