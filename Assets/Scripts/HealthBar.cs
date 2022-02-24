using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Slider slider;
    //Update slider based on our health
    public void SetHealth(int health)

    {
        slider.value = health;
    }
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health; //Defined max
        slider.value = health; //Starting value is equal to max
    }
}
