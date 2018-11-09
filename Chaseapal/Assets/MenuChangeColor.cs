using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuChangeColor : MonoBehaviour {

    public ColorVar playerColor;
    SpriteRenderer sprite;
    Color defaultColor;
    public bool selected;
    // Use this for initialization
    void Start () {
        sprite = GetComponent<SpriteRenderer>();
        defaultColor = sprite.color;
    }
	
	// Update is called once per frame
	void Update () {
		if(selected)
        {
            sprite.color = playerColor.color;
        }
        else
        {
            sprite.color = defaultColor;
        }
	}
}
