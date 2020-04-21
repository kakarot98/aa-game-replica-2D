using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public RotatorScript rotator;
    public PinSpawnScript spawner;
    private bool hasGameEnded = false;
    public static GameManager instance;

    private void Start()
    {
        if (instance == null)
            instance = this;
    }

    public void GameHasEnded()
    {
        if (hasGameEnded)
        {
            return;
        }

        
        Debug.Log("Game has ended");
        rotator.enabled = false;
        spawner.enabled = false;
        hasGameEnded = true;

    }
}
