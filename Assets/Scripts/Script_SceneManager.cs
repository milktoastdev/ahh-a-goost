using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_SceneManager : MonoBehaviour
{
    // DO NOT DELETE -------------------------------------------------------
    public GameObject _gameManager;
    public GameObject _minigameManager;
    // ---------------------------------------------------------------------
    
    // All scene names in the order they appear in the minigame manager list
    private List<string> _sceneList = new List<string> {"Scene_Ethan1","Scene_Karl1","Scene_Ariana_Capture","Scene_Ariana_Posession","Scene_Ethan2","Scene_Karl2"};
    
    private List<string> _scenesRemaining = new List<string> {};
    
    private List<string> _scenesWon = new List<string> {};

    private List<string> _scenesFailed = new List<string> {};
    
    // Start is called before the first frame update
    void Start()
    {
        //SetCurrentSceneName();
    }

    // Update is called once per frame
    void Update()
    {
        // if(_currentActiveScene() != _minigameManager.GetComponent<Script_MinigameManager>().)
    }

    public void SetCurrentSceneName(Scene scene)
    {
        scene = SceneManager.GetActiveScene();
        Debug.Log($"Scene : {scene.name as string}");
    }
    
    // Loads and sets the next scene as active
    public string ChangeScene(string _nextActiveScene, string _currentActiveScene)
    {
        // Next active scene is equivalent to the game chosen in the minigame manager
        _nextActiveScene = _sceneList[_minigameManager.GetComponent<Script_MinigameManager>().NextMinigame()];
        
        // Loads the scene
        SceneManager.LoadScene($"{_nextActiveScene}", LoadSceneMode.Additive);
        // Tells us which scene is now loaded
        Debug.Log($"Loaded {_minigameManager.GetComponent<Script_MinigameManager>()._minigamesList[_minigameManager.GetComponent<Script_MinigameManager>().NextMinigame()]} scene");

        // Sets the scene as active
        SceneManager.SetActiveScene(SceneManager.GetSceneByName($"{_nextActiveScene}"));
        // Tells us which scene is now active
        Debug.Log($"Set {_minigameManager.GetComponent<Script_MinigameManager>()._minigamesList[_minigameManager.GetComponent<Script_MinigameManager>().NextMinigame()]} as active scene");

        // What was next in line is now current
        _currentActiveScene = _nextActiveScene;

        // Next is now empty
        _nextActiveScene = null;
        
        //return scene.name;
        return _currentActiveScene;
    }
}