using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour {

    //float screenHeight = Screen.height;

	// Use this for initialization
	void Start () {
		
	}
	
    private void OnTriggerEnter2D(Collider2D collision) {
        collision.transform.position = new Vector2(transform.position.x, transform.position.y + 15);
    }
}
