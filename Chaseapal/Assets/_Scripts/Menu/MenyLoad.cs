using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenyLoad : MonoBehaviour {

    public ScoreSystem score;

    // Use this for initialization
    void Start () {
         
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Submit") > 0) {
            //score.ResetScore();
            SceneManager.LoadScene("Menu");
        }
	}
}
