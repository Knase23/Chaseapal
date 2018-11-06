using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    // Håller koll på att hoppa
    public string jumpButton = "Jump";

    Rigidbody2D Rb2d;
    float jumpMaxTime;
    float jumpTime;
    float jumpPower;
    public bool isJumping;

    // Use this for initialization
    void Start()
    {
        Rb2d = GetComponentInChildren<Rigidbody2D>();
        Rb2d.gravityScale = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(jumpButton) && !isJumping)
        {
            isJumping = true;
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
                jumpPower *= 0.9f;
            }
        }

        if (Input.GetButtonUp(jumpButton))
        {
            jumpMaxTime = 0;
        }
    }
}
