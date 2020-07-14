using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectQuitMenu : MonoBehaviour {

    
    float timer = 2;
    bool isVisible;
    bool charactherInside;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if (timer < 2) {
            timer += Time.deltaTime;
        }
        if (timer > 1 && charactherInside && isVisible) {

            if (Input.GetAxis("Submit") > 0 || Input.GetKey(KeyCode.Escape)) {
                Application.Quit();
            }


        }
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        charactherInside = true;
    }
    private void OnTriggerExit2D(Collider2D collision) {
        charactherInside = false;
    }
    private void OnBecameVisible() {
        isVisible = true;
    }
    private void OnBecameInvisible() {
        isVisible = false;
    }


}
