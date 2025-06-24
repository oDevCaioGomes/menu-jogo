using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;
using UnityEditor;

public class GameManager1 : MonoBehaviour
{
    public int pontuacaoAtual;

    public int Trash;

    public static GameManager1 Instance;

    public TextMeshProUGUI textScore;  // Corrigido aqui

    public TextMeshProUGUI textLixo;

    public GameObject PausePanel;

    public bool PauseState;

    public bool FreeMode;

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



    public void Score1(int Myscore)
    {
       
            pontuacaoAtual += Myscore;
            textScore.text = "SCORE: " + pontuacaoAtual;
    

    }

    public void ScoreFree(int Myscore)
    {

        pontuacaoAtual += Myscore;
        textScore.text = "SCORE: " + pontuacaoAtual;
        
        
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
