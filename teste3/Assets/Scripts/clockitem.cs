using UnityEngine;

public class Clockitem : MonoBehaviour
{

    
    public float scaleOfTime = 0.5f;
    public void MudarTime(float novoTempo)
    {
        scaleOfTime = novoTempo;
         Time.timeScale = scaleOfTime;
    }

    
   

    
}
