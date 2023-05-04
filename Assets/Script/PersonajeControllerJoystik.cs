using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PersonajeControllerJoystik : MonoBehaviour
{
    public Joystick joystick;
    public Rigidbody2D rb;
    public float runSpeedHorizontal = 1.5f;
    public float horizantalMovent = 1.25f;
    public float runSpeed = 10f;

    //
    Animator animator;
    private int currentAnimation = 1;
    public SpriteRenderer sr;
    public GameObject Disparo;

    public Transform PuntoBala;
    public GameObject MoventBala; //bala

    public GameObject MoventBala2;
    public GameObject MoventBala3;
    //
    public GameObject MoventBalaPrefab;

    //////
    public GameObject gameManager;
    ////
    public AudioClip[] audios;
    private AudioSource audioSource;

    bool verDisparar = false;

    //int balasLanzadas = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        currentAnimation = 1;
        //derecha
        //Debug.Log("estado de bool "+verDisparar);
        if (verDisparar)
        {
            currentAnimation = 3;
        }
        if (!verDisparar)
        {
            currentAnimation = 1;
        }
        if (horizantalMovent > 0)
        {
            currentAnimation = 2;
            sr.flipX = false;
        }
        //izquierda
        if (horizantalMovent < 0)
        {
            currentAnimation = 2;
            sr.flipX = true;

        }
        animator.SetInteger("Estado", currentAnimation);
     
    }
    private void FixedUpdate()
    {
        horizantalMovent = joystick.Horizontal * runSpeedHorizontal;
        transform.position += new Vector3(horizantalMovent, 0, 0) * Time.deltaTime * runSpeed;
    }
    public void Disparar()
    {
        var gm = gameManager.GetComponent<GameManager>();
        var uim = gameManager.GetComponent<UIManager>();
        //aca balidas si el numero de balas es mayor a 0
        if (gm.GetBalas() > 0)
        {
            //balasLanzadas += 1; 
            verDisparar = true;
            currentAnimation = 3;
            animator.SetInteger("Estado", currentAnimation);
            var currentPosition = transform.position;
            var position = new Vector3(currentPosition.x - 2, currentPosition.y, 10);
            var balaGO = Instantiate(MoventBalaPrefab, PuntoBala.position, Quaternion.identity);
            var controller = balaGO.GetComponent<MoventBalaController>();
            controller.velocidad = 10f;
            MoventBala = balaGO;
            audioSource.PlayOneShot(audios[0], 5);
            //metodo disparar que va reduciendo segun dispares
            gm.Disparar();
            //imprimes el mensaje en pantalla de las balas.
            uim.PrintBalasPuntaje(gm.GetBalas());

            //para ver las balas y cambiar de escena
            //if (balasLanzadas == 4)
            //{
            //    Debug.Log("balas" + balasLanzadas);
            //    SceneManager.LoadScene("Escena2");
            //}

        } 
        else
        {
            Debug.Log("No tienes balas:");
            verDisparar = false;
        }
    }
    public void NoDisparar()
    {
        currentAnimation = 1;
        animator.SetInteger("Estado", currentAnimation);
        verDisparar = false;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
      
        //si choca pierde vidas el zombie
        if (collision.gameObject.tag == "DeadZombie")
        {
            Debug.Log("Personaje choco con zombie");
            var gm = gameManager.GetComponent<GameManager>();
            var uim = gameManager.GetComponent<UIManager>();
            gm.PerderVidas();
            uim.PrinteVidasPersonaje(gm.GetVidasJugador());
        
        }
    }
}
