using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Bare minimum requirements all minigames should have in order to function
public class Script_Ethan_Cupboard : MonoBehaviour
{
    // PLEASE MAKE A COPY OF THIS AND TITLE IT Script_[Name]_[Game]
    // EXAMPLE : Script_Karl_Flashing
    // PLEASE MAKE THE GAME THE SAME AS FOUND IN Script_MinigameTemplate
    
    //Declaration
    public List<GameObject> cupboards = new List<GameObject>();
    public int cupboardChosen;
    
    // OnEnable is called before Start
    void OnEnable()
    {
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(CupboardRandomiser());
    }

    // Update is called once per frame
    void Update()
    {
       /*f(Input.GetKeyDown("o"))
        {
            OpenTopCupboardDoor();
            Debug.Log($"the cupboard is {cupboardChosen}");
        }*/
        //doorTimer = Time.deltaTime;
        /*while(gameObject.activeSelf)
        {
            OpenCupboardDoor();
            Debug.Log("this be firing");

        }*/
        // yea that uh breaks unity
       /*if(doorTimer > doorTimerUp)
       {
        for(int i = 0; i < bottomCupboards.Count; i++ )
            {
                Debug.Log("its doin it");
    
            }
       }*/
       

    }

    IEnumerator CupboardRandomiser()
    {
        while(true)
        {

            OpenCupboardDoor();
            
            yield return new WaitForSeconds(2.5f);
        }

  

    }

    void OpenCupboardDoor()
    {
        cupboardChosen = Random.Range(1, cupboards.Count);

        cupboards[cupboardChosen].GetComponent<Script_CupboardMaterialChange>().ChangeMaterialToOpen();



    }



    // Function for fail state

    // Function for win state

    // Function for player input

    // Functions to talk to higher scripts (UI, Minigame Manager, Game Manager etc.)
}
