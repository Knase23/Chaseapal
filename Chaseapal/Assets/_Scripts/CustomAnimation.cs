using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomAnimation : MonoBehaviour {

    public float speed;
    public Animator animator;
    AudioSource sound;
    Jump parentJump;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        
    }
	
	// Update is called once per frame
	void Update () {
        animator.SetFloat("Speed", Mathf.Abs(speed));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (parentJump == null)
        {
            parentJump = GetComponentInParent<Jump>();
        }
        parentJump.isJumping = false;

    }
}
