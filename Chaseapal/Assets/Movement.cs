using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    // Röra sig sideleds

    Rigidbody2D rb2d;
    SpriteRenderer sprite;
    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal") *5;


        //Animering av ändra håll
        if(x < 0)
        {
            sprite.flipX = true;
        }
        else
        {
            sprite.flipX = false;
        }
       

        rb2d.velocity = new Vector2(x, rb2d.velocity.y);
        
	}
}
