using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextValueSlider : MonoBehaviour {

    public Slider slider;
    public float offset;
    Text outText;
    // Use this for initialization
    private void Start()
    {
        outText = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update () {

        outText.text = Mathf.Ceil(slider.value + offset).ToString();
	}
}
