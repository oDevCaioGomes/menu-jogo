using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using System.Xml.Serialization;

public class PontoLixo : MonoBehaviour
{

    public int TrashPoint;        


    void Start()
    {
        PlayerPrefs.SetInt("TrashTest", 0);  
        }


    void Update()
    {
        
    }

    public void  TrashTest()
    {
        TrashPoint++;
        PlayerPrefs.SetInt("TrashTest", TrashPoint);
    }
}
