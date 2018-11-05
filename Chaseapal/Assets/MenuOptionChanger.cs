﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOptionChanger : MonoBehaviour {

    Color defaultColor;
    SpriteRenderer sprite;
    // Use this for initialization
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        defaultColor = sprite.color;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Color other = collision.GetComponent<ColorVar>().color;
        sprite.color = other;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        sprite.color = defaultColor;
    }
}
