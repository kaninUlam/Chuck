using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu2 : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene(1);


    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
