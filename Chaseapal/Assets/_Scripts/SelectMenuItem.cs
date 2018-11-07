using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMenuItem : MonoBehaviour {

    public string toView;
    public Camera mainCamera;
    Animator cameraAnimator;
    float timer = 2;
    Animator animateController;
	// Use this for initialization
	void Start () {
        animateController = GetComponent<Animator>();
        cameraAnimator = mainCamera.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        if (timer < 3)
        {
            timer += Time.deltaTime;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (timer > 2)
        {
            
            if (Input.GetAxis("Submit") > 0)
            {
                Debug.Log("Submited " + toView);
                animateController.SetBool("Selected", true);
                timer = 0;
                //mainCamera.transform.Translate();
            }

            if (Input.GetAxis("Cancel") > 0)
            {
                Debug.Log("Cancel " + toView);
                animateController.SetBool("Selected", false);
                timer = 0;
                //mainCamera.transform.Translate();
            }
            
        }        
    }

    void IdleMain()
    {
        animateController.SetBool("Main", true);
    }
    void IdleAbout()
    {
        animateController.SetBool("About", true);
    }
    void IdleLevelSelect()
    {
        animateController.SetBool("LevelSelect", true);
    }
    void IdlePlayerConnect()
    {
        animateController.SetBool("PlayerConnect", true);
    }
    void GoMainToLevelSelect()
    {
        animateController.SetBool("Main", true);
        animateController.SetBool("LevelSelect", true);
        animateController.SetBool("PlayerConnect", false);
        animateController.SetBool("Settings", false);
        animateController.SetBool("About", false);
    }
    void GoMainToSettings()
    {
        animateController.SetBool("Main", true);
        animateController.SetBool("Settings", true);
    }
    void GoMainToAbout()
    {
        animateController.SetBool("Main", true);
        animateController.SetBool("Settings", true);
    }
   





}
