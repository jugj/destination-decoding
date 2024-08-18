using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lebensanzeige : MonoBehaviour
{
    public Slider slider;

    public void setzemaxleben(int Leben){
    slider.maxValue = Leben;
    slider.value = Leben;
    }
    
    public void setzeleben(int Leben){
    slider.value = Leben;
    }
    
    }
