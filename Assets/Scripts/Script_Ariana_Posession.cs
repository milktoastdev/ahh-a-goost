using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Ariana_Posession : MonoBehaviour
{
    // Variables -----------------------------------------------------------
    // GameObjects attached to the items able to be posessed.
    public GameObject _theLamp;
    public GameObject _theBook;
    public GameObject _thePainting;
    public GameObject _posessedItem;
    // ---------------------------------------------------------------------

    public List<GameObject> _itemsToPosess = new List<GameObject> {};
    
    // OnEnable is called before Start
    void OnEnable()
    {
        // PickItem();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // public GameObject PickItem()
    // {
       // _posessedItem = _itemsToPosess[Random.Range(0,_itemsToPosess.Count)];
    // }

    // Function for fail state

    // Function for win state

    // Function for player input

    // Functions to talk to higher scripts (UI, Minigame Manager, Game Manager etc.)
}