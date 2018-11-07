using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMenuItem : MonoBehaviour {

    public string enterToView;
    public string cancelToView;
    public Camera mainCamera;
    float timer = 2;
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

        if (timer < 3)
        {
            timer += Time.deltaTime;
        }
        if (timer > 2 && charactherInside)
        {

            if (Input.GetAxis("Submit") > 0)
            {
                Debug.Log("Submited to " + enterToView);
                animateController.SetBool("Selected", true);
                changeStatesTo.SetState(enterToView, true);
                timer = 0;
                //mainCamera.transform.Translate();
            }

            if (Input.GetAxis("Cancel") > 0)
            {
                Debug.Log("Cancel to " + cancelToView);
                animateController.SetBool("Selected", false);
                changeStatesTo.SetState(cancelToView, true);
                timer = 0;
                //mainCamera.transform.Translate();
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








}
