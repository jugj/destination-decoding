using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelthBar : MonoBehaviour
{
  public Slider slider;

  public void setzemaxlevel(int leben){
    slider.maxValue =leben;
    slider.value = leben;
    
  }
  public void setzeleben(int leben){
    slider.value = leben;

  }
}
