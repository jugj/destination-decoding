using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Slider slider;
    // setzte Maximalleben
    public void SetzeMaxLeben(int leben) {
        slider.maxValue = leben;
        slider.value = leben;

    }

    // setze aktuelle Leben
    public void SetzeLeben(int leben) {
        slider.value = leben;
    }
}
