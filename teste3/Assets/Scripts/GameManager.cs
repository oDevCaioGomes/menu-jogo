using JetBrains.Annotations;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int LixoColetado;
    public static GameManager Instance;


    void Awake()
    {
        Instance = this;
    } 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Score(int Myscore)
    {
        LixoColetado += Myscore;
    }
}
