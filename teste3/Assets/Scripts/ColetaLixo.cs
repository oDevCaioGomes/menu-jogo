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
        PlayerPrefs.SetInt("ContarColeta", 0);  
        }


    void Update()
    {
        
    }

    public void  ContarColeta()
    {
        ColetandoLixo++;
        PlayerPrefs.SetInt("ContarColeta", ColetandoLixo);
    }
}
