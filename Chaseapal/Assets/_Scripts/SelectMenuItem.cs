using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMenuItem : MonoBehaviour {

    public string enterToView;
    public string cancelToView;
    public Camera mainCamera;
    float timer = 2;
    bool isVisible;
    bool isInTransition;
    Animator animateController;
    SetAnimatiorStates changeStatesTo;
    bool charactherInside;
    // Use this for initialization
    void Start () {
        animateController = GetComponent<Animator>();
        changeStatesTo = mainCamera.gameObject.GetComponent<SetAnimatiorStates>();
    }
	
	// Update is called once per frame
	void Update () {

        if (timer < 2)
        {
            timer += Time.deltaTime;
        }
        if (timer > 1 && charactherInside && isVisible)
        {

            if (Input.GetAxis("Submit") > 0)
            {
                
                animateController.SetBool("Selected", true);
                changeStatesTo.SetState(enterToView, true);
                isInTransition = true;
                timer = 0;
            }

            if (Input.GetAxis("Cancel") > 0)
            {
                
                animateController.SetBool("Selected", false);
                changeStatesTo.SetState(cancelToView, true);
                isInTransition = true;
                timer = 0;
                
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        charactherInside = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        charactherInside = false;
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
