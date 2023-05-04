using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabeza1Controller : MonoBehaviour
{
    public bool zombieSalto = false;
    public bool chocoZombie = false;

    public bool zombieJump()
    {
        if (zombieSalto)
        {
            return true;
        }
        return false;
    }

    public void validationJumpZombie()
    {
        zombieSalto = false;
    }
    //choca
    public bool zombieChoca()
    {
        if (chocoZombie)
        {
            return true;
        }
        return false;
    }

    public void validationChocaZombie()
    {
        chocoZombie = false;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("-------");
        if (collision.CompareTag("Player"))
        {
            Debug.Log("entro ontriger zombie");
            zombieSalto = true;
            
        }
    }
  
}
