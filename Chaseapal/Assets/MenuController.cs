using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

    public Camera mainCamera;
    SetAnimatiorStates stateOfCamera;
    bool isVisible;
    float timer;
	// Use this for initialization
	void Start () {
        stateOfCamera = mainCamera.GetComponent<SetAnimatiorStates>();
	}
	
	// Update is called once per frame
	void Update () {
        if (isVisible && timer > 0.5)
        {
            float x = Input.GetAxis("Horizontal");
            float submit = Input.GetAxis("Submit");
            if (submit > 0)
            {
                OnSubmit();
                timer = 0;
            }
            if(x > 0)
            {
                OnRight();
            }
            if(x < 0)
            {
                OnLeft();
            }
            
        }
        timer += Time.deltaTime;
	}
    void OnSubmit()
    {
        
    }
    void OnRight()
    {

    }
    void OnLeft()
    {

    }
    void OnCancel()
    {

    }
    private void OnBecameVisible()
    {
        isVisible = true;
    }

}
