using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    // Håller koll på att hoppa
    public string jumpButton = "Jump";
    public float gravityScale = 5;

    Rigidbody2D Rb2d;
    AudioSource jumpSound;
    float jumpMaxTime;
    float jumpTime;
    float jumpPower;
    public bool isJumping;

    private void Start() {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Rb2d == null)
        {
            Rb2d = GetComponentInChildren<Rigidbody2D>();
            Rb2d.gravityScale = gravityScale;
            
        }
        if(jumpSound == null)
        {
            jumpSound = GetComponentInChildren<AudioSource>();
        }

        if (Input.GetButtonDown(jumpButton) && !isJumping)
        {
            isJumping = true;
            jumpSound.Play();
            jumpMaxTime = Time.time + 0.55f;
            jumpTime = 0;
            jumpPower = 1.0f;
        }

        if (Input.GetButton(jumpButton) && Time.time < jumpMaxTime)
        {
            jumpTime += Time.deltaTime;
            Rb2d.velocity = new Vector2(Rb2d.velocity.x, jumpPower);

            if (jumpTime < 0.45)
            {
                if (jumpPower < 8)
                    jumpPower *= 1.3f;
            }
            else
            {
                jumpPower *= 0.8f;
            }
        }

        if (Input.GetButtonUp(jumpButton))
        {
            jumpMaxTime = 0;
        }
    }
}
