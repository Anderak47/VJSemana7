using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazanaController : MonoBehaviour
{
    //estas es la clase balas (Mazana) son las balas
    public GameManager gameManager;
    void Start()
    {
        //agregar esto para un prefab
        gameManager = FindObjectOfType<GameManager>();
    }
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Jugador recogió una manzana");
            AumentarBalas();
            Destroy(gameObject);
        }
    }
    private void AumentarBalas()
    {
        //aca aumentas las balas al jugador y lo imprimes en pantalla
        var gm = gameManager.GetComponent<GameManager>();
        var uim = gameManager.GetComponent<UIManager>();
        gm.GanarBalas();
        uim.PrintBalasPuntaje(gm.GetBalas());
    }
}
