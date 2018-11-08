using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerConnectController : MonoBehaviour {

    public GameObject LevelSelector;
    public Camera mainCamera;
    SetAnimatiorStates stateOfCamera;
    LevelSelectMenuController level;
    bool isVisible;
    bool isInTransition = true;
    float timer;

    public int selected;
    public int maxSizeOfSelected = 1;

    // Use this for initialization
    void Start()
    {
        stateOfCamera = mainCamera.GetComponent<SetAnimatiorStates>();
        level = LevelSelector.GetComponent<LevelSelectMenuController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isVisible && timer > 0.5)
        {
            float x = Input.GetAxis("Horizontal");
            float submit = Input.GetAxis("Submit");
            float cancel = Input.GetAxis("Cancel");
            if (submit > 0)
            {
                OnSubmit();
                isInTransition = true;
                timer = 0;
            }
            if(cancel > 0)
            {
                OnCancel();
                isInTransition = true;
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
        timer += Time.deltaTime;
    }
    void OnSubmit()
    {
        SceneManager.LoadScene(level.GetSelectedLevel());
    }
    void OnRight()
    {
        
    }
    void OnLeft()
    {
       
    }
    void OnCancel()
    {
        stateOfCamera.SetState("LevelSelect", true);
    }
    private void OnBecameVisible()
    {
        Debug.Log("I am Visible");
        isVisible = true;
    }
    private void OnBecameInvisible()
    {
        Debug.Log("LevelSelect POOOF");
        isVisible = false;
        isInTransition = false;
    }
}
