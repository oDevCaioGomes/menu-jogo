using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    public GameManager gm;

    
    public void Setup(int score)
    {
        gameObject.SetActive(true);
       
    }

    public void Start()
    {
            pointsText.text = gm.pontuacaoAtual.ToString();
        
        
    }

    public void RestartButton()
    {
        Time.timeScale = 1f; // Despausa o jogo, caso tenha sido pausado com Time.timeScale = 0
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("menu");
    }
}
