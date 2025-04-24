using System;
using UnityEngine;

public class Inimigos : MonoBehaviour
{
    public float velocidadeDoInimigo;


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
