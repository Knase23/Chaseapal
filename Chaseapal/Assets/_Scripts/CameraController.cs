using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Camera cam2P;
    public Camera cam3P;
    public Camera cam4P;

    // Use this for initialization
    void Start () {
        if (2P){ // how to know how many palyers??
            cam2P.enabled = true;
            cam3P.enabled = false;
            cam4P.enabled = false;
        } else if (3P){
            cam2P.enabled = true;
            cam3P.enabled = false;
            cam4P.enabled = false;
        } else if (4P){
            cam2P.enabled = true;
            cam3P.enabled = false;
            cam4P.enabled = false;
        }
    }

}
