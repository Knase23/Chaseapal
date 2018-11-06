using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectDamage : MonoBehaviour {

    Animator animator;
    Freeze freeze;

    // Use this for initialization
    void Start() {
        animator = GetComponentInParent<Animator>();
        freeze = GetComponentInParent<Freeze>();
    }


    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            animator.SetBool("TakeDamage", true);
            freeze.timerStart = true;
        }
    }
}
