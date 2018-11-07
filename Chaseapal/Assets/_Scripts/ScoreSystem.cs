using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour {

    public static int[] pointsList = { 100, 300, 1000, 1 };
	// Use this for initialization
	void Start () {
        //pointsList = new int[4];
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddPointToPlayer(int playerNumber)
    {
        pointsList[playerNumber]++;
    }

}
