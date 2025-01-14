using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    public Slider oxygenSlider;
    public Slider hydrogenSlider;
    public float stepSize = 0.1f;

    public Text oxygenValueText;
    public Text hydrogenValueText;

    void Update()
    {
        oxygenSlider.value = Mathf.Round(oxygenSlider.value / stepSize) * stepSize;
        hydrogenSlider.value = Mathf.Round(hydrogenSlider.value / stepSize) * stepSize;

        oxygenValueText.text = oxygenSlider.value.ToString("0.0");
        hydrogenValueText.text = hydrogenSlider.value.ToString("0.0");
    }

}
