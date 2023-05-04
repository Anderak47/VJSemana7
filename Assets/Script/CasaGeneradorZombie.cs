using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasaGeneradorZombie : MonoBehaviour
{
    public GameObject XombieGenerador;
    public float delay = 3;
    float timer=0; 
    void Start()
    {
        
    }
    void Update()
    {
        timer += Time.deltaTime;
        if( timer > delay)
        {
            Instantiate(XombieGenerador, transform.position, Quaternion.identity);
            timer=0;

        }
      
    }
}
