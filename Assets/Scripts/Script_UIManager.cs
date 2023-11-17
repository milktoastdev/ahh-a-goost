using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Manages anything on the Canvas.
public class Script_UIManager : MonoBehaviour
{
    // DO NOT DELETE -------------------------------------------------------
    public GameObject _gameManager;
    // ---------------------------------------------------------------------
    
    private float _timeAllowed = 30.0f;
    private float _timeRemaining = 0.0f;
    public TextMeshProUGUI _countDown;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If the minigame is still going...
        if(_gameManager.GetComponent<Script_MinigameManager>()._isMinigameRunning == true)
        {
            // Countdown and update the UI
            _timeRemaining -= Time.deltaTime;
            _countDown.text = ($"00:{_timeRemaining}");
            
            // If there is no time remaining...
            if (_timeRemaining < 0)
            {
                _countDown.text = ("00:00");
                // The player loses
                _gameManager.GetComponent<Script_MinigameManager>().MinigameFailed();
                Debug.Log("Out of time...");
            }
        }       
    }

    // Resets the countdown
    public void TimerReset()
    {
        _timeRemaining = _timeAllowed;
        Debug.Log("Timer has been reset");
    }
    
    public void DisplayTitleScreen()
    {
        
    }

    public void DisplayTutorial()
    {

    }

    public void DisplayPause()
    {

    }

    public void DisplayWin()
    {

    }

    public void DisplayLose()
    {

    }

    public void DisplayCredits()
    {

    }  
}
