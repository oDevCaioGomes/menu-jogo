using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Referência para o componente Animator do personagem
    private Animator anim;

    public bool podeMover = true;

    // Velocidade de movimento do personagem
    public float moveSpeed = 5f;

    // Limites horizontais da tela (esquerda e direita)
    private float limiteEsquerdaX;
    private float limiteDireitaX;

    // Referência para o componente SpriteRenderer, usado para virar o sprite
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Obtém o componente Animator anexado ao GameObject
        anim = GetComponent<Animator>();
        // Obtém o componente SpriteRenderer do personagem
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Calcula os limites esquerdo e direito da câmera em coordenadas do mundo
        Vector3 limiteEsquerda = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 10f));
        Vector3 limiteDireita = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 10f));

        // Armazena os valores X dos limites para uso posterior
        limiteEsquerdaX = limiteEsquerda.x;
        limiteDireitaX = limiteDireita.x;


    }

    void Update()
    {
        // Chama o método de movimentação do jogador a cada frame
        MovimentarJogador();
    }

    // Responsável por mover o jogador com base na posição do mouse
    private void MovimentarJogador()
    {

        if (!podeMover) return;
        // Obtém a posição atual do mouse na tela
        Vector3 mousePos = Input.mousePosition;

        // Define a distância da câmera para a conversão correta para coordenadas do mundo
        mousePos.z = 10f;

        // Converte a posição do mouse da tela para o mundo
        Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(mousePos);

        // Limita o valor X da posição do mouse dentro dos limites da tela
        float alvoX = Mathf.Clamp(worldMousePos.x, limiteEsquerdaX, limiteDireitaX);

        // Define a nova posição de destino mantendo Y e Z do personagem
        Vector3 targetPos = new Vector3(alvoX, transform.position.y, transform.position.z);

        // Calcula a direção do movimento com base na posição atual e no destino
        float direcao = alvoX - transform.position.x;

        // Vira o sprite do personagem de acordo com a direção do movimento
        Flip(direcao);

        // Move suavemente o personagem em direção ao destino
        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
    }

    // Inverte o sprite do personagem dependendo da direção
    private void Flip(float direcao)
    {
        // Se estiver indo para a direita, vira o sprite para a esquerda (flipX true)
        if (direcao > 0f)
            spriteRenderer.flipX = true;
        // Se estiver indo para a esquerda, vira o sprite para a direita (flipX false)
        else if (direcao < 0f)
            spriteRenderer.flipX = false;

        // Define a variável "speed" no Animator com o valor absoluto da direção
        anim.SetFloat("speed", Math.Abs(direcao));
    }

   
}
