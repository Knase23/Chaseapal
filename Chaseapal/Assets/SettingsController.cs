using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsController : MonoBehaviour {

    public Camera mainCamera;
    SetAnimatiorStates stateOfCamera;
    bool isVisible;
    float timer;
    public ChangeSliderValue[] sliders;
    int selected;

    // Use this for initialization
    void Start()
    {
        stateOfCamera = mainCamera.GetComponent<SetAnimatiorStates>();
        selected = sliders.Length;

    }

    // Update is called once per frame
    void Update()
    {
        if (isVisible)
        {

            if (timer > 0.3)
            {
                float y = Input.GetAxis("Vertical");
                if (y > 0)
                {
                    if (selected != sliders.Length)
                        sliders[selected].SetSelected(false);

                    OnUp();

                    if (selected != sliders.Length)
                        sliders[selected].SetSelected(true);
                    timer = 0;
                }
                if (y < 0)
                {
                    if (selected != sliders.Length)
                        sliders[selected].SetSelected(false);

                    OnDown();

                    if (selected != sliders.Length)
                        sliders[selected].SetSelected(true);
                    timer = 0;
                }
            }

            if (timer > 0.1)
            {
                float x = Input.GetAxis("Horizontal");

                float submit = Input.GetAxis("Submit");

                if (selected == sliders.Length && submit > 0)
                {
                    OnSubmit();
                    timer = 0;
                }
                if (x > 0)
                {
                    OnRight();
                    timer = 0;
                }
                if (x < 0)
                {
                    OnLeft();
                    timer = 0;
                }


            }
        }
        timer += Time.deltaTime;
    }
    void OnSubmit()
    {
        stateOfCamera.SetState("Main", true);
    }
    void OnRight()
    {
        if(selected != sliders.Length)
        {
            sliders[selected].IncreaseValue();
        }
    }

    void OnLeft()
    {
        if (selected != sliders.Length)
        {
            sliders[selected].DecreaseValue();
        }
    }

    void OnUp()
    {
        if (selected > 0)
        {
            
            selected--;
           
        }
    }
    
    void OnDown()
    {
        if (selected < sliders.Length)
        {
            
            selected++;
            
        }
        
    }
    private void OnBecameVisible()
    {
        Debug.Log("SettingsController Visable");
        isVisible = true;
    }
    private void OnBecameInvisible()
    {
        Debug.Log("SettingsController Visable");
        isVisible = false;
    }
}
