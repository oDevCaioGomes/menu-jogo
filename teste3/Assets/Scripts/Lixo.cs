using System;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Lixo : MonoBehaviour
{
    public float velocidadeDoInimigo;
    public int ScoreGanho;
    public int PoinTrash;
    AudioManager audioManager;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            // Chama a função para coletar o lixo
            collision.gameObject.GetComponent<ColetaLixo>().LixoColetado();



            // Atualiza a pontuação
            GameManager.Instance.AddScore(ScoreGanho);
            audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
            audioManager.PlaySFX(audioManager.collect);



            // collision.gameObject.GetComponent<PontoLixo>().TrashTest();
            // Passa o valor de pointrash para o método MyTrash do GameManager


            // Destroi o inimigo
            Destroy(this.gameObject);


        }
    }




    void Start()
    {

    }

    void Update()
    {
        // Movimento do inimigo
        MovimentarInimigo();

    }

    private void MovimentarInimigo()
    {

        transform.Translate(Vector3.down * velocidadeDoInimigo * Time.deltaTime);


    }



}