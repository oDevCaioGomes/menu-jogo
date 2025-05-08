using System;
using UnityEngine;

public class Lixo : MonoBehaviour
{
    public float velocidadeDoInimigo;
    public int ScoreGanho;
    public int PoinTrash;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            // Chama a função para coletar o lixo
            collision.gameObject.GetComponent<ColetaLixo>().LixoColetado();

             

            // Atualiza a pontuação
            GameManager.Instance.Score(ScoreGanho);


            collision.gameObject.GetComponent<PontoLixo>().TrashTest();
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
