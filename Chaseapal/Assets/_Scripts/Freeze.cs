using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : MonoBehaviour {

    float timer;
    Movement move;
    Jump jump;
    public bool timerStart;
    Animator animator;

    // Use this for initialization
    void Start() {
        move = GetComponentInParent<Movement>();
        jump = GetComponentInParent<Jump>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {

        if (timerStart) {
            if (timer < 2) {
                move.enabled = false;
                jump.enabled = false;
            } else {
                move.enabled = true;
                jump.enabled = true;
                timerStart = false;
                animator.SetBool("TakeDamage", false);
            }

            timer += Time.deltaTime;
        } else if (timer > 0) {
            timer = 0;
        }
    }
}
