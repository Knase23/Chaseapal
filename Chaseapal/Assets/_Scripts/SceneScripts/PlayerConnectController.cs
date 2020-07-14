using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerConnectController : MonoBehaviour {

    public GameObject LevelSelector;
    public Camera mainCamera;
    SetAnimatiorStates stateOfCamera;
    LevelSelectMenuController level;
    bool isVisible;
    bool isInTransition = true;
    float timer;

    public GameObject[] players;
    SelectColor[] playersSelectColor;

    bool[] colorTaken = { false,false,false,false}; // 0 = green 1 = Red
    // Use this for initialization
    void Start()
    {
        stateOfCamera = mainCamera.GetComponent<SetAnimatiorStates>();
        level = LevelSelector.GetComponent<LevelSelectMenuController>();
        playersSelectColor = new SelectColor[players.Length];
        for (int i = 0; i < playersSelectColor.Length; i++)
        {
            playersSelectColor[i] = players[i].GetComponent<SelectColor>();
        }
    }
    private void Awake()
    {
        bool[] boolArray = { false, false, false, false };
        string[] stringArray = { "", "", "", "" };
        SpawnPlayers.arrayOfSelectedColors = stringArray;
        SpawnPlayers.arrayOfShouldSpawn = boolArray;
    }

    // Update is called once per frame
    void Update()
    {
        if (isVisible && timer > 0.5)
        {
            float x = Input.GetAxis("Horizontal");
            float submit = Input.GetAxis("Submit");
            float cancel = 0;//Input.GetAxis("Vertical");
            if (submit > 0)
            {
                OnSubmit();
                isInTransition = true;
                timer = 0;
            }
            if (cancel > 0 || Input.GetKey(KeyCode.C)) 
            {
                OnCancel();
                isInTransition = true;
                timer = 0;
            }
            if (x > 0)
            {
                OnRight();
                timer = 0;
            }
            if (x < 0)
            {
                OnLeft();
                timer = 0;
            }
            for (int i = 0; i < 4; i++)
            {
                if (!playersSelectColor[i].spawn)
                {
                    if (Input.GetAxis("p" + (i + 1) + "_Button 0") > 0 && !colorTaken[0])
                    {
                        playersSelectColor[i].spawn = true;
                        if (playersSelectColor[i].color.Length == 0)
                        {
                            playersSelectColor[i].color = "green";
                        }
                        colorTaken[0] = true;
                        timer = 0;
                    }
                    if (Input.GetAxis("p" + (i + 1) + "_Button 1") > 0 && !colorTaken[1])
                    {
                        playersSelectColor[i].spawn = true;
                        if (playersSelectColor[i].color.Length == 0)
                        {
                            playersSelectColor[i].color = "red";
                        }
                        colorTaken[1] = true;
                        timer = 0;
                    }
                    if (Input.GetAxis("p" + (i + 1) + "_Button 2") > 0 && !colorTaken[2])
                    {
                        playersSelectColor[i].spawn = true;
                        if (playersSelectColor[i].color.Length == 0)
                        {
                            playersSelectColor[i].color = "blue";
                        }
                        colorTaken[2] = true;
                        timer = 0;
                    }
                    if (Input.GetAxis("p" + (i + 1) + "_Button 3") > 0 && !colorTaken[3])
                    {
                        playersSelectColor[i].spawn = true;
                        if (playersSelectColor[i].color.Length == 0)
                        {
                            playersSelectColor[i].color = "yellow";
                        }
                        colorTaken[3] = true;
                        timer = 0;
                    }

                    if (playersSelectColor[i].spawn)
                    {
                        playersSelectColor[i].spawnDino();
                    }
                    
                }
                else
                {
                    if (Input.GetAxis("p" + (i + 1) + "_Button 0") > 0 && colorTaken[0] && playersSelectColor[i].color == "green")
                    {
                        playersSelectColor[i].spawn = false;
                        playersSelectColor[i].color = "";
                        playersSelectColor[i].KillDino();
                        colorTaken[0] = false;
                        timer = 0;
                    }
                    if (Input.GetAxis("p" + (i + 1) + "_Button 1") > 0 && colorTaken[1] && playersSelectColor[i].color == "red")
                    {
                        playersSelectColor[i].spawn = false;
                        playersSelectColor[i].color = "";
                        playersSelectColor[i].KillDino();
                        colorTaken[1] = false;
                        timer = 0;
                    }
                    if (Input.GetAxis("p" + (i + 1) + "_Button 2") > 0 && colorTaken[2] && playersSelectColor[i].color == "blue")
                    {
                        playersSelectColor[i].spawn = false;
                        playersSelectColor[i].color = "";
                        playersSelectColor[i].KillDino();
                        colorTaken[2] = false;
                        timer = 0;
                    }
                    if (Input.GetAxis("p" + (i + 1) + "_Button 3") > 0 && colorTaken[3] && playersSelectColor[i].color == "yellow")
                    {
                        playersSelectColor[i].spawn = false;
                        playersSelectColor[i].color = "";
                        playersSelectColor[i].KillDino();
                        colorTaken[3] = false;
                        timer = 0;
                    }
                }
            }
        }
        timer += Time.deltaTime;
    }
    void OnSubmit()
    {
        int numberOfActivePlayers = 0;
        for (int i = 0; i < playersSelectColor.Length; i++)
        {
            
            SpawnPlayers.arrayOfSelectedColors[i] = playersSelectColor[i].color;
            SpawnPlayers.arrayOfShouldSpawn[i] = playersSelectColor[i].dinoIsSpawned;
            if(SpawnPlayers.arrayOfShouldSpawn[i])
            {
                numberOfActivePlayers++;
            }
        }
        if(numberOfActivePlayers > 1)
        {
            SceneManager.LoadScene(level.GetSelectedLevel());
        }
       

    }
    void OnRight()
    {
        
    }
    void OnLeft()
    {
       
    }
    void OnCancel()
    {
        for (int i = 0; i < playersSelectColor.Length; i++)
        {
            playersSelectColor[i].KillDino();
        }
        stateOfCamera.SetState("LevelSelect", true);
    }
    private void OnBecameVisible()
    {
        isVisible = true;
    }
    private void OnBecameInvisible()
    {
        isVisible = false;
        isInTransition = false;
    }
}
