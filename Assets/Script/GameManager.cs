using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int Vidas = 1; //perder vidas
    private int muerteZombie = 0;
    private int numeroMonedas = 0;
    private int VidasJugador = 2;
    public AudioClip[] audios;
    private AudioSource audioSource;

    private int Balas = 5;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    //zombie
    public void MuerteZombie() {
        muerteZombie += 1;
    }
    public int GetMuerte() { 
        return muerteZombie;
        
    }
    //Monedas
    public void GanarMonedas() {
        numeroMonedas += 1;
        audioSource.PlayOneShot(audios[0],4);
    }
    public int GetMonedas() { 
        return numeroMonedas;
    }
    //VIDAS JUGADOR
    public void GanarVida()
    {
        VidasJugador += 1;
    }
    public int GetVidas()
    {
        return Vidas;
    }
    //perder Vidas jugador cuando choca zombie
    public void PerderVidas()
    {
        if (VidasJugador > 0)
        {
            VidasJugador -=1;
        }
        if (VidasJugador <= 0) {
            Time.timeScale = 0;
        }
    }
    public int GetVidasJugador()
    {
        return VidasJugador;
    }
    //GANAR BALAS 
    public void Disparar()
    {
        if (Balas > 0)
        {
            // Código para disparar
            Balas -= 1;
        }
        //si solo quiero que al disparar 5 balas me cambie de escena ojo Habilitar PersonajeJoytink
        //if (Balas == 5)
        //{
        //    SceneManager.LoadScene("Escena2");
        //}
        else {
            Debug.Log("No tienes balas");
            return;
        }
    }
    public int GetBalas()
    {
        return Balas;
    }
    public void GanarBalas()
    {
        Balas += 5;
        audioSource.PlayOneShot(audios[0], 4);
    }
}
