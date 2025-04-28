using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using System.Xml.Serialization;

public class ColetaLixo : MonoBehaviour
{

    public int ColetandoLixo;        


    void Start()
    {
        PlayerPrefs.SetInt("LixoColetado", 0);  
        }


    void Update()
    {
        
    }

    public void  LixoColetado()
    {
        ColetandoLixo++;
        PlayerPrefs.SetInt("LixoColetado", ColetandoLixo);
    }
}
