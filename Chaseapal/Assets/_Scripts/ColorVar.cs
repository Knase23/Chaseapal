using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorVar : MonoBehaviour {

    public Color color;
    public int playerNumber;

    private void Start()
    {
        playerNumber = GetComponentInParent<SelectColor>().playerNumber;
    }
}
