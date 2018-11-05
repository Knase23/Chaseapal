using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {


    // Kolla om den kollidierar med en spelare
    // Beroende på spelaren så ändras färg och en timer startar.

    // Om timer är igång och en annan spelare kollidera
    //Byt färg 
    // Kanske startar om timern - Diskutera om det

    //När timern är slut, då försvinner den

    SpriteRenderer sprite;
    // Use this for initialization
    void Start () {
        sprite = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Color other = collision.GetComponent<ColorVar>().color;
        sprite.color = other;
    }
}
