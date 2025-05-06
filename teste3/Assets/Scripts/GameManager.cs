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


    void Start ()
    {
        pontuacaoAtual = 0;
        textScore.text = "SCORE: " + pontuacaoAtual;

        
        
        
    }

    
    
    void Awake()
    {
        Instance = this;
    } 

    
    
    public void Score(int Myscore)
    {
       pontuacaoAtual += Myscore;
       textScore.text = "SCORE: " + pontuacaoAtual;
    }

    
    
    public void MyTrash(int Lixo)
    {
       Trash += Lixo;
       textLixo.text = "Lixo Coletado: " + Trash;
    }
}
