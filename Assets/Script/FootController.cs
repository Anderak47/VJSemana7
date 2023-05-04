using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootController : MonoBehaviour
{
    //public const int MAX_JUMPS = 2;
    //private bool onGround = false;
    //private int currentJumps = 0;
    public bool canJump = false;
    //public int currentJump = 0;

    //public bool CanJump()
    //{
    //    return onGround || (!onGround && currentJumps < MAX_JUMPS);
    //}
    //public void Jump()
    //{
    //    currentJumps++;
    //    onGround = false;

    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.name);
        //onGround = true;
        //currentJumps = 0;
        canJump = true;
    }
}
