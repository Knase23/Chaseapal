using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show2 : MonoBehaviour {

    Text text;
    LevelSelectMenuController level;

    // Use this for initialization
    void Start() {
        text = GetComponent<Text>();
        level = GetComponentInParent<LevelSelectMenuController>();
    }

    // Update is called once per frame
    void Update() {
        //Debug.Log(level.GetSelectedLevel());

        if (level.GetSelectedLevel() == "Level4") {
            text.enabled = false;
        } else {
            text.enabled = true;
        }
    }
}
