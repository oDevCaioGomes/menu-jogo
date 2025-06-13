using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Congratulations : MonoBehaviour
{

    public GameManager gm;
    [Header("Configurações de Pontuação")]
    public int score = 0;
    public int pontuacaoAtual = 20; // Pontuação necessária

    [Header("UI")]
     public TextMeshProUGUI scoreText;    // Texto do score atual
    public GameObject congratulations;        // Painel ou imagem de parabéns

    [Header("Próxima Fase (Opcional)")]
    public string nomeDaProximaCena;        // Coloque aqui o nome da próxima fase

    void Start()
    {
        congratulations.SetActive(false);     // Esconde o painel de parabéns no início
        AtualizarScoreUI();
    }

    

    public void AddScore(int amount)
    {
        score += amount;
        AtualizarScoreUI();

        if (score >= pontuacaoAtual)
        {
            MostrarParabens();
        }
    }

    void AtualizarScoreUI()
    {
        scoreText.text = "Score: " + score;
    }

    void MostrarParabens()
    {
       congratulations.SetActive(true);
    }

    // 🚀 Botão para ir para a próxima fase (se quiser)
    public void CarregarProximaCena()
    {
        SceneManager.LoadScene("Level2");
    }

    // 🔙 Botão para voltar ao menu (opcional)
    public void VoltarMenu(string nomeCenaMenu)
    {
        SceneManager.LoadScene(nomeCenaMenu);
    }
}
