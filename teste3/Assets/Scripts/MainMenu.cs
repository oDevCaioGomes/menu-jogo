using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMenu : MonoBehaviour
{
    public void PlayModoLivre()
    {
    SceneManager.LoadSceneAsync(1);
    }
    
    public void PlayDesafio()
    {
    SceneManager.LoadSceneAsync(2);
    }

    
    

    public void QuitGame()
    {
        Application.Quit();
    }

}
