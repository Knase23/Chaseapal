using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectColor : MonoBehaviour {

    public string color = "blue";
    public int playerNumber;

    public GameObject blueDino;
    public GameObject greenDino;
    public GameObject redDino;
    public GameObject yellowDino;


    // Use this for initialization
    void Start () {

        color.ToLower();
        switch (color)
        {
            case "blue":
               Instantiate(blueDino,gameObject.transform);
                break;
            case "green":
                Instantiate(greenDino, gameObject.transform);
                break;
            case "red":
                Instantiate(redDino, gameObject.transform);
                break;
            case "yellow":
                Instantiate(yellowDino, gameObject.transform);
                break;
            default:
               Instantiate(blueDino, gameObject.transform);
                break;
        }
        
	}
}
