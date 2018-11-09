using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeSliderValue : MonoBehaviour {


    public float power = 0.01f;
    Slider slider;
    MenuChangeColor color;
	// Use this for initialization
	void Start () {
        slider = GetComponentInChildren<Slider>();
        color = GetComponentInChildren<MenuChangeColor>();
	}
    public void IncreaseValue()
    {
        if (slider.value < slider.maxValue)
        {
            slider.value += power;
        }
    }
    public void DecreaseValue()
    {
        if (slider.value > slider.minValue)
        {
            slider.value -= power;
        }
    }
    public void SetSelected(bool state)
    {
        color.selected = state;
    }

}
