using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IsAlive : MonoBehaviour
{
    public bool playerAlive = true;

    private void Update()
    {
        if (playerAlive == false)
        {
            SceneManager.LoadScene(sceneBuildIndex: 5);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Traps")
        {
            Debug.Log("Dead");
            playerAlive = false;
            
        }
    }
}
