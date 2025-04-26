using System;
using UnityEngine;

public class Inimigos : MonoBehaviour
{
    public float velocidadeDoInimigo;
    public int ScoreGanho;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<ColetaLixo>().ContarColeta();
            GameManager.Instance.Score(ScoreGanho);
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        MovimentarInimigo();
    }

    private void MovimentarInimigo()
    {
        transform.Translate(Vector3.down * velocidadeDoInimigo * Time.deltaTime);    
    }
}
