using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * This script controls the infill of the health bar. Unity has an inbuilt slider which we can implaement and control using the script.
 * This sloder can have a max value and can either decrease in float values or whole values. 
 * 
 * All this script does is pass the health values to the unity slider and the unity slider takes care of the rest.
 */

public class healthBar : MonoBehaviour
{
    public Slider slider;

    public void setMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void setHealth(int health)
    {
        slider.value = health;
    }
}

