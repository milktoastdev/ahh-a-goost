using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_SceneManager : MonoBehaviour
{
    // DO NOT DELETE -------------------------------------------------------
    public GameObject _gameManager;
    // ---------------------------------------------------------------------
    
    public List<string> _sceneNames = new List<string> {"Scene_Ethan1","Scene_Karl1"};
    private string _currentActiveScene;
    private string _nextActiveScene;
    private bool _isNextActive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Ariana game 1
    void ScenePosession()
    {
        // Loads the scene
        SceneManager.LoadScene("Scene_Ariana_Posession", LoadSceneMode.Additive);
        Debug.Log("Loaded posession scene");

        // Sets the scene as active
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Scene_ArianaPosession"));
        Debug.Log("Set posession as active scene");
    }

    // Ariana game 2
    void SceneCapture()
    {

    }

    // Ethan game 1
    void SceneCupboards()
    {

    }

    // Ethan game 2
    void SceneDifference()
    {

    }

    // Karl game 1
    void SceneCleaning()
    {

    }

    // Karl game 2
    void SceneGooing()
    {

    }
}
