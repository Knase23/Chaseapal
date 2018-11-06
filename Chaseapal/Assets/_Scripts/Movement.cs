using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    // Röra sig sideleds
    public string inputMovement = "Horizontal";
    Rigidbody2D rb2d;
    CustomAnimation customAnimation;
    SpriteRenderer sprite;	
	// Update is called once per frame
	void Update () {


        if(rb2d == null)
        {
            rb2d = GetComponentInChildren<Rigidbody2D>();
            
            
        }
        if (sprite == null)
        {
            sprite = GetComponentInChildren<SpriteRenderer>();
        }
        if(customAnimation == null)
        {
            customAnimation = GetComponentInChildren<CustomAnimation>();
        }




        float x = Input.GetAxis(inputMovement) * 5;

        customAnimation.speed = Mathf.Abs(x);
        //Animering av ändra håll
        if(x < 0)
        {
            sprite.flipX = true;
        }
        if (x > 0)
        {
            sprite.flipX = false;
        }
       

        rb2d.velocity = new Vector2(x, rb2d.velocity.y);
        
	}
}
