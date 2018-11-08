using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour {

    public static int[] pointsList = { 1, 1, 1, 1 };
   
	// Use this for initialization
	void Start () {
        
        
	}


    public static void AddPointToPlayer(int playerNumber)
    {
        pointsList[playerNumber]++;
    }

    public void ResetScore() {
        for(int i = 0; i < 4; i++) {
            pointsList[i] = 0;
        }
    }

}
