using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAnimatiorStates : MonoBehaviour {

    Animator animateController;
    // Use this for initialization
    void Start () {
        animateController = GetComponent<Animator>();
    }

    public void IdleMain()
    {
        animateController.SetBool("Main", true);
        animateController.SetBool("LevelSelect", false);
        animateController.SetBool("PlayerConnect", false);
        animateController.SetBool("Settings", false);
        animateController.SetBool("About", false);
    }
    public void IdleAbout()
    {
        animateController.SetBool("About", true);
        animateController.SetBool("LevelSelect", false);
        animateController.SetBool("PlayerConnect", false);
        animateController.SetBool("Settings", false);
        animateController.SetBool("Main", false);
    }
    public void IdleLevelSelect()
    {
        animateController.SetBool("LevelSelect", true);
        animateController.SetBool("Main", false);
        animateController.SetBool("PlayerConnect", false);
        animateController.SetBool("Settings", false);
        animateController.SetBool("About", false);
    }
    public void IdlePlayerConnect()
    {
        animateController.SetBool("PlayerConnect", true);
        animateController.SetBool("LevelSelect", false);
        animateController.SetBool("Main", false);
        animateController.SetBool("Settings", false);
        animateController.SetBool("About", false);
    }
    public void IdleSettings()
    {
        animateController.SetBool("Settings", true);
        animateController.SetBool("PlayerConnect", false);
        animateController.SetBool("LevelSelect", false);
        animateController.SetBool("Main", false);
        animateController.SetBool("About", false);
    }
    public void SetState(string stateName,bool value)
    {
        animateController.SetBool(stateName, value);
    }
}
