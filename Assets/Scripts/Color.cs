using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour
{
    [SerializeField] private int ColorValor;
    [SerializeField] private AudioClip Sonido_Pintura;
    
    public int CantCambios = 0;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
            audioSource.PlayOneShot(Sonido_Pintura);
        }
    }
}
