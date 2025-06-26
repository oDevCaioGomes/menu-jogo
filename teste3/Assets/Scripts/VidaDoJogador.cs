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
    public GameObject PlayerDesactive;

    public GameObject botaoReset;
    public int maxHealthShield;
    public int healthShield;
    AudioManager audioManager;

    public GameObject shieldPlayer;


    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }





    void Start()
    {
        vidaAtual = vidaMax;

        shieldPlayer.SetActive(true);
        temEscudo = true;



        
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

    public void ShieldActive()
    {
        healthShield = maxHealthShield;
        shieldPlayer.SetActive(true);
        temEscudo = true;

        
    }
    public void TomarDano(int Dano)
    {

        if (temEscudo == false)
        {


            vidaAtual -= Dano;
            audioManager.PlaySFX(audioManager.damage);


            if (vidaAtual <= 0)
            {

                Time.timeScale = 0;
                GameOverTeste.SetActive(true);
                PlayerDesactive.SetActive(false);
                botaoReset.SetActive(true);



            }

        }
        else
        {

            healthShield -= Dano;
            if (healthShield <= 0)
            {
                shieldPlayer.SetActive(false);
                temEscudo = false;
            }

        }
    }
    


    
    

}
