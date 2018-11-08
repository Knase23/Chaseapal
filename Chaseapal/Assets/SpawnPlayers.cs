using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayers : MonoBehaviour {
    public static string[] arrayOfSelectedColors = { "","","",""};
    public static bool[] arrayOfShouldSpawn = { false, false, false, false };

    public void CleanArrays()
    {

        for (int i = 0; i < 4; i++)
        {
            arrayOfSelectedColors[i] = "";
            arrayOfShouldSpawn[i] = false;
        }
        Debug.Log("Clean Static Array");

    }
    public void ShowContent()
    {
        for (int i = 0; i < 4; i++)
        {
            Debug.Log("Player 1:" + arrayOfSelectedColors[i]);
            Debug.Log("Player 1 Should Spawn:" + arrayOfShouldSpawn[i]);
        }
        
    }
    public int GetNumberOfPlayers()
    {
        int counter = 0;
        foreach (bool shouldExist in arrayOfShouldSpawn)
        {
            if(shouldExist)
            {
                counter++;
            }
        }
        return counter;
    }
}
