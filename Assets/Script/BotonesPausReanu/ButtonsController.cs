using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Pausar() {
        Time.timeScale = 0f;
    }
    public void Reanudar() {
        Time.timeScale = 1f;
    }
    public void Exit() {
        SceneManager.LoadScene("Menu");
    }
    //menu
    public void Play()
    {
        SceneManager.LoadScene("Escena");
    }
    public void FinalizarJuego() {
        Application.Quit();
    }
}
