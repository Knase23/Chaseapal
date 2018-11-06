using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezePlayer : MonoBehaviour {

    public GameObject player;
    Movement m;
    Jump j;
    // Use this for initialization
	void Start () {
        m = player.GetComponent<Movement>();
        j = player.GetComponent<Jump>();
	}
	
    void DisablePlayer()
    {
        m.enabled = false;
        j.enabled = false;
    }
    void ActivatePlayer()
    {
        m.enabled = true;
        j.enabled = true;
    }

	// Update is called once per frame
	void Update () {
		
	}
}
