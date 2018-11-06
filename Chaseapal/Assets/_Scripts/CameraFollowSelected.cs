using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowSelected : MonoBehaviour {


    public Camera mainCamera;
    private Vector3 offSet;
    public bool selected;
    // Use this for initialization
    void Start () {
        offSet = mainCamera.transform.position - transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        if (selected)
        {
            mainCamera.transform.position = transform.position + offSet;
        }
	}
    void IsCameraSelected()
    {
        selected = true;
    }
    void NotCameraSelected()
    {
        selected = false;
    }

}
