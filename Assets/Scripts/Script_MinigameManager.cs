using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_MinigameManager : MonoBehaviour
{
    // Variables -----------------------------------------------------------
        // To add and subtract from minigame lists
    int _currentMinigame;
        // Called in NextMinigame()
    int _maximumMinigames = 6;
    // ---------------------------------------------------------------------
    
    // Lists ---------------------------------------------------------------
    // Each minigame's controller will need to be added to this list in engine.
    // IN THE CORRECT ORDER
    public List<GameObject> _minigameObjects = new List<GameObject>{};
    
    // All minigames overall. This list should not change so it can reset the other lists for new players.
    private List<string> _minigamesList = new List<string>{"Cupboards","Cleaning","Capturing","Posessed","Difference","Flashing"};
        
    // Holds minigames not yet played this run
    private List<string> _minigamesRemaining = new List<string>{};
    
    // Holds won minigames so they can't be repeated in a run
    private List<string> _minigamesWon = new List<string>{};
        
    // Holds lost minigames for the opportunity to retry later
    private List<string> _minigamesFailed = new List<string>{};
    // ---------------------------------------------------------------------
    
    // OnEnable is called before Start. 
    // The object this script is attached to is inactive by default.
    void OnEnable()
    {
        Debug.Log("MinigameManager enabled");
        
        // Inititates the minigame loop.
        NextMinigame();
        Debug.Log("Minigame loop initiated");
    }

    void ResetGame()
    {
        Debug.Log("Game being reset...");

        // Goes through the list to add every game back to games remaining in the correct order
        for(int i = 0; i < _minigamesList.Count; i++)
        {
            _minigamesRemaining.Add(_minigamesList[i]);
            Debug.Log($"Added {_minigamesList[i]} to _minigamesRemaining");
        }
    }

    // Called by the minigame itself when the game is won
    public void MinigameWon()
    {
        Debug.Log("Current minigame won");

        // Adds the current game to the Won list
        _minigamesWon.Add("{_minigamesList[_currentMinigame]}");
        Debug.Log($"{_minigamesList[_currentMinigame]} was added to _minigamesWon");
        
        // Removes the current game from the overall list
        _minigamesList.Remove("{_minigamesList[_currentMinigame]}");
        Debug.Log($"{_minigamesList[_currentMinigame]} was removed from _minigamesWon");
        
        // Makes sure it can't accidentally remove a game
        _currentMinigame = -1;
        Debug.Log($"The value of _currentMinigame has been reset to {_currentMinigame}");

        // Progresses to the next minigame
        NextMinigame();
        Debug.Log("Calling next minigame...");
    }
    
    // Called by the minigame itself when the game is lost if the player has remaining lives
    public void MinigameFailed()
    {
        // Puts the game in the failed list to be retried last
        // NextMinigame
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    // Holds the loop checking if the quantity of minigames in a run has been met.
    public int NextMinigame()
    {
        Debug.Log("Next minigame called!");
        
        int _thisMinigame = -1;
        
        for(int i = 0; i < _maximumMinigames; i++)
        {
            _thisMinigame = Random.Range(0,_minigamesList.Count);

            _currentMinigame = _thisMinigame;          
        }

        return _thisMinigame;
    }
}