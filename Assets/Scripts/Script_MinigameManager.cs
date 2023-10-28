using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Talked to by the minigames, talks to higher scripts about them.
// Manages information about the collection overall
public class Script_MinigameManager : MonoBehaviour
{
    // Variables------------------------------------------------------------
    // Makes it easier to change the information in the for loop
    int maximumMinigames = 8;
    // ---------------------------------------------------------------------
    
    // Lists----------------------------------------------------------------
    private List<string> minigamesList = new List<string>{"Books","Cupboards","Cleaning","Capturing","Trapping","Posessed","Difference","Flashing"};
    private List<string> minigamesPlayed = new List<string>{};
    private List<string> minigamesFailed = new List<string>{};
    // ---------------------------------------------------------------------
    
    // OnEnable is called before Start
    void OnEnable()
    {
        // Starts the loop of a set number of minigames per playthrough
        NextMinigame();
    }

    void MinigameWon()
    {

    }
    
    void MinigameFailed()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    // Holds the loop checking if the quantity of minigames in a run has been met.
    void NextMinigame()
    {
        for(int i = 0; i < maximumMinigames; i++)
        {
            // Function to generate next minigame
        }
    }
}
