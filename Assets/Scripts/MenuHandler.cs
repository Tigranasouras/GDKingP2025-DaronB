using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuHandler : MonoBehaviour
{
    public void goToMenu(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
    }

    public void goToCharacter(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Character Selection");
    }

    public void goToGame(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void restartGameScene(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void goToEndGame(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game Over");
    }
}
