using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject CameraController;
    [SerializeField] private GameObject Azul;
    [SerializeField] private GameObject Verde;
    [SerializeField] private GameObject Azul1;
    [SerializeField] private GameObject Verde1;
    [SerializeField] private GameObject Azul2;
    [SerializeField] private GameObject Verde2;
    [SerializeField] private GameObject Azul3;
    [SerializeField] private GameObject Verde3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MenuPrincipal() 
    {
        SceneManager.LoadScene("Menu_Inicial");
    }

    public void Restart()
    {
        Player.gameObject.GetComponent<Color_Personaje>().ResetColor();
        Verde.gameObject.GetComponent<Color>().CantCambios = 0;
        Azul.gameObject.GetComponent<Color>().CantCambios = 0;
        Verde1.gameObject.GetComponent<Color>().CantCambios = 0;
        Azul1.gameObject.GetComponent<Color>().CantCambios = 0;
        Verde2.gameObject.GetComponent<Color>().CantCambios = 0;
        Azul2.gameObject.GetComponent<Color>().CantCambios = 0;
        Verde3.gameObject.GetComponent<Color>().CantCambios = 0;
        Azul3.gameObject.GetComponent<Color>().CantCambios = 0;
        switch (CameraController.gameObject.GetComponent<CamaraController>().currentLevel) 
        {
            case 0:
                Player.gameObject.transform.position = new Vector3(19.519f, -2.74f, 0);
                break;
            case 1:
                Player.gameObject.transform.position = new Vector3(19.5163f, 9.268312f, 0);
                break;
            case 2:
                Player.gameObject.transform.position = new Vector3(19.51628f, 22.26069f, 0);
                break;
            case 3:
                Player.gameObject.transform.position = new Vector3(19.51608f, 34.26069f, 0);
                break;
        }
    }
}
