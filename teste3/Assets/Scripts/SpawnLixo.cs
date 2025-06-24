using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class SpawnLixo : MonoBehaviour
{
    public GameObject[] objetosParaSpawnar;
    public Transform[] pontosDeSpawn;
    public float tempoEntreSpawns;
    public float tempoAtualSpawn;
    public static GameManager Instance;
    
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
    meuLixo.GetComponent<Lixo>().velocidadeDoInimigo = 7 +(Score / 10);
    


    // Reset do tempo
        tempoAtualSpawn = tempoEntreSpawns;
}

    
}


