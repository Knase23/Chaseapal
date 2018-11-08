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
    Color defaultColor;
    SpriteRenderer sprite;
    int playerNumber;
    // Use this for initialization
    void Start () {
        sprite = GetComponent<SpriteRenderer>();
        defaultColor = sprite.color;
    }
	

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            ColorVar other = collision.GetComponent<ColorVar>();
            sprite.color = other.color;
            playerNumber = other.playerNumber;
        }
    }
    public bool IsColorChanged()
    {
        if (sprite.color != defaultColor)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void ColorDefualtChange()
    {
        sprite.color = defaultColor;
    }
    public int GetPlayerNumber()
    {
        return playerNumber;
    }
}
