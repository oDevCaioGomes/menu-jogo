using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaDoJogador : MonoBehaviour
{
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
