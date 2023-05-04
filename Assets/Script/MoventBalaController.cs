using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoventBalaController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidad;
    public float velocidadY = 0f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 7);
    }
    void Update()
    {
        transform.position += new Vector3(velocidad * Time.deltaTime, velocidadY * Time.deltaTime, 0);
        //rb.velocity = new Vector2(velocityX, velocityY); //PF
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DeadZombie")) 
        {
            Debug.Log("Bala colisiono con zombie");
            Destroy(this.gameObject);
        }
    }
}
