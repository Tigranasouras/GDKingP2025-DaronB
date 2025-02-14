using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerOverhead : MonoBehaviour


{

    public int dodges;
    // Start is called before the first frame update
    void Start()
    {
        dodges = 0;
        
    }

    
    //method for increasing dodges
  //Make method for a possible ball death so the player can win
    public void Dodged(){
        dodges++;
        Debug.Log("Dodged! Good job" + dodges);

    }

    public void Die(){
        Debug.Log("I have died");
        Destroy(gameObject);
        goToEndGame();
        //initiate the playerdead Gui
    }
 public void goToEndGame(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game Over");
    }

}
