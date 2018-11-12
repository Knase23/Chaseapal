using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MixValues : MonoBehaviour {

    public AudioMixer audioMixer;
    private void Start()
    {
        audioMixer.SetFloat("MasterVolume", GetComponent<Slider>().value);
    }

    public void SetMasterVolume(float v)
    {
        audioMixer.SetFloat("MasterVolume", v);
    }
    public void SetPlayerVolume(float v)
    {
        audioMixer.SetFloat("PlayerVolume", v);
    }
    public void SetMusicVolume(float v)
    {
        audioMixer.SetFloat("MusicVolume", v);
    }
}
