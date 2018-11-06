using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomAnimation : MonoBehaviour {

    public float speed;
    public Animator animator;
    Jump parentJump;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        parentJump = GetComponentInParent<Jump>();
    }
	
	// Update is called once per frame
	void Update () {
        animator.SetFloat("Speed", Mathf.Abs(speed));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        parentJump.isJumping = false;
    }
}
