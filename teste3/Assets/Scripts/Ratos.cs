using UnityEngine;

public class Ratos : MonoBehaviour
{

AudioManager audioManager;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           
            collision.gameObject.GetComponent<VidaDoJogador>().TomarDano(1);

             audioManager.PlaySFX(audioManager.damage);

            // Destroi o inimigo
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
