using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour
{
    [SerializeField] private int ColorValor;
    private int CantCambios = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.CompareTag("Player")) 
        {
            if (CantCambios % 2 == 1)
            {
                player.gameObject.GetComponent<Color_Personaje>().DeshacerColor(ColorValor);
            }
            else
            {
                player.gameObject.GetComponent<Color_Personaje>().CambiarColor(ColorValor);
            }
            CantCambios++;
        }
    }
}
