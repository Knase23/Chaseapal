using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadVictroyScreen : MonoBehaviour {

    public Timer timer;
    float delayTimer = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!timer.GetIsAnyTimeLeft()) {

            if(delayTimer > 3) {
                SceneManager.LoadScene("VictoryGameOver");
            }

            delayTimer += Time.deltaTime;
        }
	}
}
