using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonedaController : MonoBehaviour
{
     public GameManager gameManager;

    void Start()
    {
       
    }
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            Debug.Log("cojio moneda");
            NumeroMonedas();
            Destroy(this.gameObject);
        }
    }
    private void NumeroMonedas()
    {
        var gm = gameManager.GetComponent<GameManager>();
        var uim = gameManager.GetComponent<UIManager>();
        gm.GanarMonedas();
        uim.PrintMonedas(gm.GetMonedas());
        //si coje 3 monedas le da 1 vida al jugador
        if (gm.GetMonedas() == 4)
        {
            //gm.GanarVida();
            //uim.PrinteVidasPersonaje(gm.GetVidasJugador());
            SceneManager.LoadScene("Escena2");
        }
    }

}
