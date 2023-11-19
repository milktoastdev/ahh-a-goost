using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_GameManager : MonoBehaviour
{
    // Every scene should have a Game Manager object with all scripts *except* for the individual minigame template script attached.
    // DO NOT DELETE -------------------------------------------------------
    public GameObject _minigameManager;
    // ---------------------------------------------------------------------
    
    // Variables -----------------------------------------------------------
    int _startingLives = 3;
    int _remainingLives;
    // ---------------------------------------------------------------------
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Resets lives
    // Starts gameplay loop in Minigame Manager
    public void StartGame()
    {
        _remainingLives = _startingLives;
        // Debug.Log($"Lives have been reset to {_remainingLives}");
        
        // Debug.Log("Start Game function called...");
        _minigameManager.GetComponent<Script_MinigameManager>().NextMinigame();
        // Debug.Log("Start Game function executed");
    }

    // Closes built out application
    public void QuitGame()
    {
        // Debug.Log("Quitting game...");
        Application.Quit();
        // Debug.Log("Game has been quit, see you next time!");
    }

    // Called when player completes all games with life remaining
    public void GameWin()
    {
        Debug.Log("Game win function called");
        // Instantiates a UI element win tile
        
        // Instantiates a UI button to return to title screen
            // Calls scene manager to load and set title screen to active
        // Instantiates a UI button to quit
            // Calls QuitGame() function
        Debug.Log("Game win function executed");
    }

    // Called when the player has no remaining life
    public void GameOver()
    {
        Debug.Log("Game over function called");

        Debug.Log("Game over function executed");
    }
}