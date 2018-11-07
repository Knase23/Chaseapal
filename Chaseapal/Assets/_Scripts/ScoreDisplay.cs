using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    private Text text;
    private int score;
    public int playerNumber;
    private bool atTop = false;
    private Vector2 Pos;
    private int highScore = 0;
    float timer = 0;

    // Use this for initialization
    void Start() {
        text = GetComponentInChildren<Text>();
        score = ScoreSystem.pointsList[playerNumber];
        Pos = transform.position;
        CheckPersentage();
    }

    private void Update() {

        if(timer < 0.2) {
            RaisePodium();
            
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void CheckPersentage() {
        for (int i = 0; i < 4; i++) {
            if(i != playerNumber) {
                int tempScore = ScoreSystem.pointsList[i];
                if(tempScore > highScore) {
                    highScore = tempScore;
                } 
            }
        }
        if(score > highScore) {
            highScore = score;
        }
    }

    private void RaisePodium() {

        //float refScore =  highScore / 10;
        float persentage =  (float)score / (float)highScore;
        
        Debug.Log("persentage " + persentage);

        if (!atTop) {
            transform.Translate(0, 0.01f, 0);

            if (transform.position.y  > (4f * persentage) - 5f) {
                atTop = true;
                DisplayText();
            }
        }
    }

    void DisplayText() {
        text.text = "" + score;
    }
}