using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieController : MonoBehaviour
{
    SpriteRenderer sr;
    Animator animator;
    public float velocity = 0.9f;
    private Rigidbody2D rb;

    public GameManager gameManager;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        //agregar cuando es un Trigger
        gameManager = FindObjectOfType<GameManager>();

    }
    void Update()
    {

        rb.velocity = new Vector2(-velocity, 0);
        sr.flipX = true;

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="balaDead") {
            Debug.Log("entro triguer zombie controllerr");
            MuertesZombie3();
        }
    }
    public void MuertesZombie3() {
        var gm = gameManager.GetComponent<GameManager>();
        var uim = gameManager.GetComponent<UIManager>();
        gm.MuerteZombie();
        uim.PrintMuerteZombie(gm.GetMuerte());
    }
}
