using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    // Röra sig sideleds
    public string inputMovement = "Horizontal";
    Rigidbody2D rb2d;
    public Animator animator;
    SpriteRenderer sprite;
    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis(inputMovement) *5;

        animator.SetFloat("Speed", Mathf.Abs(x));
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
