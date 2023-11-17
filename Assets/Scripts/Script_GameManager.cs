using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_GameManager : MonoBehaviour
{
    // Every scene should have a Game Manager object with all scripts *except* for the individual minigame template script attached.
    // DO NOT DELETE -------------------------------------------------------
    public GameObject _gameManager;
    // ---------------------------------------------------------------------
    
    // Variables -----------------------------------------------------------
    int _startingLives = 3;
    int _remainingLives;
    // ---------------------------------------------------------------------
    
    void NewGame()
    {
        // Sets initial lives without interfereing with overall start value
        _remainingLives = _startingLives;

        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
        
        // Load titlescreen elements
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Attached to Start button
    // Will start gameplay loop
    public void StartGame()
    {

    }

    // Attached to Quit button
    // Will close the built out version
    public void QuitGame()
    {

    }

    // Called when player completes all games with life remaining
    public void GameWin()
    {

    }

    // Called when the player has no remaining life
    public void GameOver()
    {

    }
}