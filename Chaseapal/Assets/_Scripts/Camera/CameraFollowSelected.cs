using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowSelected : MonoBehaviour {


    public Camera mainCamera;
    public bool selected;
    // Use this for initialization
    void IsCameraSelected()
    {
        selected = true;
    }
    void NotCameraSelected()
    {
        selected = false;
    }

}
