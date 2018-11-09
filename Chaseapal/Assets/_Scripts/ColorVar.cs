using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorVar : MonoBehaviour {

    public Color color;
    public int playerNumber;
    public bool enablePlayerNumber = true;
    private void Start()
    {
        if (enablePlayerNumber)
        {
            playerNumber = GetComponentInParent<SelectColor>().playerNumber;
        }
    }
}
