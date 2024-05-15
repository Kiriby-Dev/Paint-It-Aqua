using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject CameraController;
    [SerializeField] private GameObject Azul;
    [SerializeField] private GameObject Verde;
    [SerializeField] private GameObject Azul1;
    [SerializeField] private GameObject Verde1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Restart()
    {
        Player.gameObject.GetComponent<Color_Personaje>().ResetColor();
        Verde.gameObject.GetComponent<Color>().CantCambios = 0;
        Azul.gameObject.GetComponent<Color>().CantCambios = 0;
        Verde1.gameObject.GetComponent<Color>().CantCambios = 0;
        Azul1.gameObject.GetComponent<Color>().CantCambios = 0;
        switch (CameraController.gameObject.GetComponent<CamaraController>().currentLevel) 
        {
            case 0:
                Player.gameObject.transform.position = new Vector3(19.519f, -2.74f, 0);
                break;
            case 1:
                Player.gameObject.transform.position = new Vector3(19.5163f, 9.268312f, 0);
                break;
        }
    }
}
