using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsAlive : MonoBehaviour
{
    public bool playerAlive = true;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Traps")
        {
            Debug.Log("Dead");
            playerAlive = false;
        }
    }
}
