using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int pontuacaoAtual;

    public int Trash;

    public static GameManager Instance;

    public TextMeshProUGUI textScore;  // Corrigido aqui

    public TextMeshProUGUI textLixo;
    public int scoreNextlevel = 20;


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
            LoadNextLevel();
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



    
}
