using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text MuerteText;
    public Text NumeroMonedas;

    public Text VidasPersonaje;
    public Text GameOver;
    public Text BalaPuntaje;
    public void PrintBalasPuntaje(int bala) {
        BalaPuntaje.text = "Bala " + bala;
    }
    public void PrintMuerteZombie(int muertes) {
        MuerteText.text = "Puntos: " + muertes;
    }
    public void PrintMonedas(int moneda)
    {
        NumeroMonedas.text = "Llaves: " + moneda;
    }
    public void PrinteVidasPersonaje(int vidas) {
        VidasPersonaje.text = "Vidas: " + vidas;
        if (vidas <= 0)
        {
            GameOver.text = "GAME OVER";
        }
    }
}
