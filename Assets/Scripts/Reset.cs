using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject CameraController;

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
        Player.gameObject.GetComponent<Color_Personaje>().ResetColor();

        switch (CameraController.gameObject.GetComponent<CamaraController>().currentLevel) 
        {
            case 0:
                Player.gameObject.transform.position = new Vector3(19.519f, -2.74f, 0);
                break;
            case 1:
                Player.gameObject.transform.position = new Vector3(19.5163f, 9.268312f, 0);
                break;
            case 2:
                Player.gameObject.transform.position = new Vector3(19.51628f, 21.26069f, 0);
                break;
            case 3:
                Player.gameObject.transform.position = new Vector3(19.51608f, 33.26069f, 0);
                break;
            case 4:
                Player.gameObject.transform.position = new Vector3(19.51993f, 46.26069f, 0);
                break;
        }
    }
}
