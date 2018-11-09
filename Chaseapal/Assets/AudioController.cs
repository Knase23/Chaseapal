using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour {

    Slider slider;
    MixValues mix;
	// Use this for initialization
	void Start () {
        slider = GetComponent<Slider>();
        mix = GetComponent<MixValues>();
	}
	
	// Update is called once per frame
	void Update () {
        mix.SetMasterVolume(slider.value);	
	}
}
