using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetColor : MonoBehaviour {

    Color color;
    SpriteRenderer sprite;
  
    void Start() {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update() {
        color = GetComponentInParent<SpriteRenderer>().color;
        sprite.color = color
    }
}
