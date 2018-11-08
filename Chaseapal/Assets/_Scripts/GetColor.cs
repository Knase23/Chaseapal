using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetColor : MonoBehaviour {

    public Color color;
    public SpriteRenderer otherSprite;
    SpriteRenderer sprite;
  
    void Start() {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update() {
        color = otherSprite.color;
        sprite.color = color;
    }
}
