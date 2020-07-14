using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutController : MonoBehaviour {

    public Camera mainCamera;
    SetAnimatiorStates stateOfCamera;
    bool isVisible;
    bool isInTransition = true;
    float timer;

    public int selected;
    public int maxSizeOfSelected = 1;

    // Use this for initialization
    void Start()
    {
        stateOfCamera = mainCamera.GetComponent<SetAnimatiorStates>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isVisible && timer > 0.5)
        {
            float submit = Input.GetAxis("Submit");
            float cancel = Input.GetAxis("Cancel");
            if (submit > 0)
            {
                OnSubmit();
                isInTransition = true;
                timer = 0;
            }
            


        }
        timer += Time.deltaTime;
    }

    void OnSubmit()
    {
        stateOfCamera.SetState("Main", true);
    }
    private void OnBecameVisible()
    {       
        isVisible = true;
    }
    private void OnBecameInvisible()
    {  
        isVisible = false;
        isInTransition = false;
    }
}
