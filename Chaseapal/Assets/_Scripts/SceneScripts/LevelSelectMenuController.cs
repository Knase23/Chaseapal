using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectMenuController : MonoBehaviour {

    public Camera mainCamera;
    SetAnimatiorStates stateOfCamera;
    Animator animator;
    bool isVisible;
    bool isInTransition = true;
    float timer;

    int selected;
    public string[] levels;
    // Use this for initialization
    void Start()
    {
        stateOfCamera = mainCamera.GetComponent<SetAnimatiorStates>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isVisible && timer > 0.5)
        {
            float x = Input.GetAxis("Horizontal");
            float submit = Input.GetAxis("Submit");
            if (submit > 0)
            {
                OnSubmit();
                isInTransition = true;
                timer = 0;
            }
            if (x > 0 || Input.GetKey(KeyCode.RightArrow))
            {
                OnRight();
                animator.SetInteger("LevelSelected", selected);
                timer = 0;
            }
            if (x < 0 || Input.GetKey(KeyCode.LeftArrow))
            {
                OnLeft();
                animator.SetInteger("LevelSelected", selected);
                timer = 0;
            }

        }
        timer += Time.deltaTime;
    }
    void OnSubmit()
    {
        stateOfCamera.SetState("PlayerConnect", true);
    }
    void OnRight()
    {
        if(selected < levels.Length - 1)
        {
            selected++;
        }
    }
    void OnLeft()
    {
        if (selected > 0)
        {
            selected--;
        }
    }
    void OnCancel()
    {

    }
    public string GetSelectedLevel()
    {
        return levels[selected];
    }
    private void OnBecameVisible()
    {
        //Debug.Log("I am Visible");
        isVisible = true;
    }
    private void OnBecameInvisible()
    {
        //Debug.Log("LevelSelect POOOF");
        isVisible = false;
    }

}
