using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Camera cam2P;
    public Camera cam3P;
    public Camera cam4P;
    bool is2P = false;
    bool is3P = false;
    bool is4P = true;

    // Use this for initialization
    void Start () {
        if (is2P){ 

            cam2P.enabled = true;
            cam3P.enabled = false;
            cam4P.enabled = false;

        } else if (is3P){

            cam2P.enabled = false;
            cam3P.enabled = true;
            cam4P.enabled = false;

        } else if (is4P){

            cam2P.enabled = false;
            cam3P.enabled = false;
            cam4P.enabled = true;

        }
    }
}
