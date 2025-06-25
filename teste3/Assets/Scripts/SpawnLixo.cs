using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class SpawnLixo : MonoBehaviour
{
    public GameObject[] objetosParaSpawnar;
    public Transform[] pontosDeSpawn;
    public float tempoEntreSpawns;
    public float tempoAtualSpawn;

    public GameManager gameManager;



    void Start()
    {
        tempoAtualSpawn = tempoEntreSpawns;
    }

    // Update is called once per frame
    void Update()
    {
        tempoAtualSpawn -= Time.deltaTime;

        if (tempoAtualSpawn <= 0)
        {
            SpawnarObjeto();
        }


    }

    private void SpawnarObjeto()
    {



        int objetoAleatorio = UnityEngine.Random.Range(0, objetosParaSpawnar.Length);
        int pontoDeSpawnAleatorio = UnityEngine.Random.Range(0, pontosDeSpawn.Length);

        GameObject meuLixo = Instantiate(objetosParaSpawnar[objetoAleatorio], pontosDeSpawn[pontoDeSpawnAleatorio].position, Quaternion.Euler(0f, 0f, 0));

       
        meuLixo.GetComponent<Lixo>().velocidadeDoInimigo = 7 + (GameManager.Instance.pontuacaoAtual / 5.5f);
        

        // Reset do tempo
        tempoAtualSpawn = tempoEntreSpawns;
       
    }


}


