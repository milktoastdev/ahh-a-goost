using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Manages player-oriented information
// Highest script, the Overlord, if you will.
public class Script_GameManager : MonoBehaviour
{
    // Variables -----------------------------------------------------------
    int _startingLives = 3;
    int _remainingLives;
    // ---------------------------------------------------------------------
    
    // Start is called before the first frame update
    void Start()
    {
        // Sets initial lives without interfereing with overall start value
        _remainingLives = _startingLives;
        
        // Load titlescreen elements
    }

    // Update is called once per frame
    void Update()
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