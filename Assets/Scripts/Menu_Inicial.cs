using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Inicial : MonoBehaviour
{
    public void Jugar() 
    {
        SceneManager.LoadScene("Juego");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void Salir() 
    {
        Debug.Log("Salir...");
        Application.Quit();
    }
}
