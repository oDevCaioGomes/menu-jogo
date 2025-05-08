using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaDoJogador : MonoBehaviour
{
    
    public Image[] Vida;

    public int vidaMax;
    public int vidaAtual;
    public bool temEscudo;

    

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
        if(temEscudo == false)
        {
            vidaAtual -= Dano;
            

            if(vidaAtual <= 0)
            {
                Debug.Log("Você morreu!");
            }
        }
    }
}
