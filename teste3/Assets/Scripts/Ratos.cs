using UnityEngine;

public class Ratos : MonoBehaviour
{


     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<VidaDoJogador>().TomarDano(1);

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
