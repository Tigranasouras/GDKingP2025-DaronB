using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuHandler : MonoBehaviour
{
    public void goToMenu(){
        SceneManager.LoadScene("Main Menu");
    }

    public void goToCharacter(){
        SceneManager.LoadScene("Character Selection");
    }

    public void goToGame(){
        SceneManager.LoadScene("Game");
    }

    public void restartGameScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void goToEndGame(){
        SceneManager.LoadScene("End Game");
    }
}
