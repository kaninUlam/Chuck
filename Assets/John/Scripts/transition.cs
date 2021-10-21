using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class transition : MonoBehaviour
{
    int i = 0;

    private void Start()
    {
        i = SceneManager.GetActiveScene().buildIndex;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Chuck Standing"))
        {
            SceneManager.LoadScene(i+1);
        }
    }
}
