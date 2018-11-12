using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectColor : MonoBehaviour {

    public string color;
    public int playerNumber;
    public bool spawn;
    public bool dinoIsSpawned;
    public bool ignoreGlobalPlayers;
    public GameObject blueDino;
    public GameObject greenDino;
    public GameObject redDino;
    public GameObject yellowDino;


    // Use this for initialization
    void Start () {
        if(!ignoreGlobalPlayers)
        {
            color = SpawnPlayers.arrayOfSelectedColors[playerNumber];
            spawn = SpawnPlayers.arrayOfShouldSpawn[playerNumber];
        }
        

        if (spawn && !dinoIsSpawned)
        {
            spawnDino();
        } else
        {
            GetComponent<Movement>().enabled = false;
            GetComponent<Jump>().enabled = false;
        }
        
	}
    private void Update()
    {
        if(spawn && !dinoIsSpawned)
        {
            spawnDino();
            Debug.Log("Spawning Dino");
        }
    }

    public void spawnDino()
    {
        color.ToLower();
        switch (color)
        {
            case "blue":
                Instantiate(blueDino, gameObject.transform);
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
        if (playerNumber < SpawnPlayers.arrayOfSelectedColors.Length)
        {
            SpawnPlayers.arrayOfSelectedColors[playerNumber] = color;
        }
            dinoIsSpawned = true;
    }
    public void KillDino()
    {
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        dinoIsSpawned = false;
        SpawnPlayers.arrayOfSelectedColors[playerNumber] = "";
    }
    public void ChangeColor()
    {
        foreach(Transform child in transform) {
            GameObject.Destroy(child.gameObject);
        }
        spawnDino();
    }
}
