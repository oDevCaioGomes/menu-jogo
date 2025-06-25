/*using System;
using UnityEngine;

public class SpawnRatoCarro : MonoBehaviour
{
    public GameObject[] objetosParaSpawnar;
    public Transform[] pontosDeSpawn;
    public float tempoEntreSpawns = 2f;
    private float tempoAtualSpawn;

    public float velocidadeRato = 5f; // Velocidade configurável

    void Start()
    {
        tempoAtualSpawn = tempoEntreSpawns;
    }

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

        // Instancia o objeto
        GameObject objetoSpawnado = Instantiate(
            objetosParaSpawnar[objetoAleatorio],
            pontosDeSpawn[pontoDeSpawnAleatorio].position,
            Quaternion.identity // Rotação padrão
        );

        // Adiciona automaticamente o script de movimento
        MoverParaEsquerda mover = objetoSpawnado.AddComponent<MoverParaEsquerda>();
        mover.velocidade = velocidadeRato;

        tempoAtualSpawn = tempoEntreSpawns;
    }
}
*/