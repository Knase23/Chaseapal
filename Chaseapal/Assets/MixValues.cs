using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixValues : MonoBehaviour {

    public AudioMixer audioMixer;
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
