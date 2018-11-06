using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDespawn : MonoBehaviour {


    public float disableTime = 3;
    public float enableTime = 1;
    public bool ableToRespawn = true;
    float timer = 0;
    ChangeColor chaneCol;
    SpriteRenderer sprite;
    EdgeCollider2D[] edgeCollider;
    BoxCollider2D boxCollider;
	// Use this for initialization
	void Start () {
        sprite = GetComponent<SpriteRenderer>();
        chaneCol = GetComponent<ChangeColor>();
        edgeCollider = GetComponents<EdgeCollider2D>();
        boxCollider = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {

        if (chaneCol.IsColorChanged())
        {
            timer += Time.deltaTime;
            if(timer > disableTime)
            {
                DisableComponents();

            }

            if(timer > disableTime + enableTime && ableToRespawn)
            {
                EnableComponents();
                chaneCol.ColorDefualtChange();
                timer = 0;
            }
        }
		
	}
    private void DisableComponents()
    {
        foreach (var edges in edgeCollider)
        {
            edges.enabled = false;
        }
        
        boxCollider.enabled = false;
        sprite.enabled = false;
    }
    private void EnableComponents()
    {
        foreach (var edges in edgeCollider)
        {
            edges.enabled = true;
        }        
        boxCollider.enabled = true;
        sprite.enabled = true;
    }
}
