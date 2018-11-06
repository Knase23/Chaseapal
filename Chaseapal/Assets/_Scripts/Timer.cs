using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float startingTime;
    private bool isAnyTimeLeft;

    private Text text;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        isAnyTimeLeft = true;

    }
	
	// Update is called once per frame
	void Update () {

        if (isAnyTimeLeft) {
            startingTime -= Time.deltaTime;

            text.text = "" + (int)startingTime;
        }

        if (startingTime < 0.5) {
            isAnyTimeLeft = false;
            text.text = "TIME´S UP";
        }
	}

    private bool GetIsAnyTimeLeft() {
        return isAnyTimeLeft;
    }
}
