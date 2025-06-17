using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;
using UnityEditor;

public class GameManager : MonoBehaviour
{
    public int pontuacaoAtual;

    public int Trash;

    public static GameManager Instance;

    public TextMeshProUGUI textScore;  // Corrigido aqui

    public TextMeshProUGUI textLixo;

    public int scoreNextlevel = 20;


    public GameObject congratulations;

    public GameObject PausePanel;
    public bool PauseState;

    void Start()
    {
        pontuacaoAtual = 0;
        textScore.text = "SCORE: " + pontuacaoAtual;




    }



    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Destroy(gameObject);
        }
    }



    public void Score(int Myscore)
    {
        pontuacaoAtual += Myscore;
        textScore.text = "SCORE: " + pontuacaoAtual;
        if (pontuacaoAtual >= scoreNextlevel)
        {
            Time.timeScale = 0;
            congratulations.SetActive(true);
        }

    }

    void LoadNextLevel()
    {
        int nextSceneIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneIndex);



    }






    public void MyTrash(int Lixo)
    {
        Trash += Lixo;
        textLixo.text = "Lixo Coletado: " + Trash;
    }


    public void Pause()
    {

        if (PauseState == true)
        {
            PauseState = false;
            Time.timeScale = 1;

        }
        else
        {
            PauseState = true;
            Time.timeScale = 0;
        }
    }


    


}
