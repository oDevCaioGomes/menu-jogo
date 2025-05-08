using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class kitar : MonoBehaviour
{
     public void QuitGame()
    {
       SceneManager.LoadSceneAsync(0);
    }

}
