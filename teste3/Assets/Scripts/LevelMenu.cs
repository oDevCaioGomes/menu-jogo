using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
   public void OpenLevel(int levelId)
   {
      string levelName = "Level" + levelId;
      SceneManager.LoadScene(levelName);

   }

   public void Level2()
   {
      SceneManager.LoadSceneAsync(2);
   }

   public void QuitGame()
   {
      SceneManager.LoadSceneAsync(0);


   }


   public void Menu()
   {
      SceneManager.LoadSceneAsync(0);
   }

   public void Store()
   {
      SceneManager.LoadSceneAsync(5);
   }

   public void Creditos()
   {
      SceneManager.LoadSceneAsync(6);
   }


}
