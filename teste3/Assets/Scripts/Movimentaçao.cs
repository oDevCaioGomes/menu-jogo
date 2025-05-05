using UnityEngine;

public class TesteFlipCerto : MonoBehaviour
{
    private Rigidbody2D corpo;
    private SpriteRenderer sprite;
    private float velocidade = 3.0f;
    
    void Start()
    {
        corpo = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        
        Flip(horizontal);
        corpo.linearVelocity = new Vector2(horizontal * velocidade, corpo.linearVelocity.y);
    }

    private void Flip(float horizontal){

        if (horizontal > 0){
            sprite.flipX = true;    
        }else if (horizontal < 0){
            sprite.flipX = false;
        }
    }
    
}
