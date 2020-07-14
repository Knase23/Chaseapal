using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectDamage : MonoBehaviour {

    Animator animator;
    Freeze freeze;

    public AudioClip damage;
    public AudioSource damagePlayerSound;

    // Use this for initialization
    void Start() {
        animator = GetComponentInParent<Animator>();
        freeze = GetComponentInParent<Freeze>();
        damagePlayerSound.clip = damage;
    }


    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            animator.SetBool("TakeDamage", true);
            damagePlayerSound.Play();
            freeze.timerStart = true;
        }
    }
}
