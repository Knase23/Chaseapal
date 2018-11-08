using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Camera cam2P;
    public Camera cam3P;
    public Camera cam4P;

    int numberOfPlayers = 0;


    // Use this for initialization
    void Start () {

        for(int i = 0; i < 4; i++) {
            if (SpawnPlayers.arrayOfShouldSpawn[i])
                numberOfPlayers++;
        }
        


        if (numberOfPlayers == 2){ 

            cam2P.enabled = true;
            cam3P.enabled = false;
            cam4P.enabled = false;

        } else if (numberOfPlayers == 3) {

            cam2P.enabled = false;
            cam3P.enabled = true;
            cam4P.enabled = false;

        } else if (numberOfPlayers == 4) {

            cam2P.enabled = false;
            cam3P.enabled = false;
            cam4P.enabled = true;

        }
    }
}
