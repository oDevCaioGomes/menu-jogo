using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class VidaDoJogador : MonoBehaviour
{

    public Image[] Vida;

    public int vidaMax;
    public int vidaAtual;
    public bool temEscudo;
    public GameObject GameOverTeste;

    
    


    void Start()
    {
        vidaAtual = vidaMax;
    }

    // Update is called once per frame
    void Update()
    {
        HealthLogic();
    }

    void HealthLogic()
    {
        for (int i = 0; i < Vida.Length; i++)
        {
            if (Vida[i] == null) continue; // Evita erro se algum slot estiver vazio
            if (i < vidaAtual)
            {
                Vida[i].enabled = true;
            }
            else
            {
                Vida[i].enabled = false;
            }

        }

    }

    public void TomarDano(int Dano)
    {
        if (temEscudo == false)
        {
            vidaAtual -= Dano;


            if (vidaAtual <= 0)
            {
                Time.timeScale = 0;
                GameOverTeste.SetActive(true);
                
                
                GameOver();
            }
        }
    }


    public GameOverScreen GameOverScreen;
    public void GameOver()
    {
        if (GameOverScreen != null)
        {
            GameOverScreen.Setup(vidaAtual);
            GameObject.FindWithTag("Player").GetComponent<PlayerController>().podeMover = false;
            Time.timeScale = 0f;
        }
    }

    

}
