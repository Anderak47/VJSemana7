using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementController : MonoBehaviour
{
    public FootController footController;
    public float jumpForce = 400f;
    private Rigidbody2D rb;
    public LateralesController lateralesController;
 
    public AudioClip [] audios;
    private AudioSource audioSource;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
      
    }
    void Update()
    {
        //if (Input.GetKeyUp(KeyCode.Space) && footController.CanJump())
        //{
        //    rb.AddForce(transform.up * jumpForce);
        //    footController.Jump();
        //}     
        if (Input.GetKeyDown(KeyCode.Space))
        {
            clickSaltar();
        }
    }
    //botton pantalla
    public void clickSaltar() {
        bool goJump = (footController.canJump && !lateralesController.nextJump()) || (footController.canJump && lateralesController.nextJump()) || (!footController.canJump && lateralesController.nextJump());

        if (goJump)
        {
            this.impulseAdd(this.jumpForce);
            audioSource.PlayOneShot(audios[0]);
        } 
    }
    private void impulseAdd(float jumpForce)
    {
        rb.AddForce(new Vector2(0, jumpForce));
        footController.canJump = false;
        lateralesController.validationJump();
    }

}
