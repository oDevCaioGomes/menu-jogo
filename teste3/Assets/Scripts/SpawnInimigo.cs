using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnInimigo : MonoBehaviour
{
    public GameObject[] objetosParaSpawnar;
    public Transform[] pontosDeSpawn;
    public float tempoEntreSpawns;
    public float tempoAtualSpawn;

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

    Instantiate(objetosParaSpawnar[objetoAleatorio], pontosDeSpawn[pontoDeSpawnAleatorio].position, Quaternion.Euler(0f, 0f, 0));


    // Log para imprimir o nome do objeto e do ponto de spawn
    Debug.Log("Spawnou: " + objetosParaSpawnar[objetoAleatorio].name + 
              " no ponto: " + pontosDeSpawn[pontoDeSpawnAleatorio].name);

    // Reset do tempo
    tempoAtualSpawn = tempoEntreSpawns;
}

    
}


