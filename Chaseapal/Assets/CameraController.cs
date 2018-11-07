using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Camera cam2P;
    public Camera cam3P;
    public Camera cam4P;

    // Use this for initialization
    void Start () {
        cam2P = GetComponentInChildren<CameraControl>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
