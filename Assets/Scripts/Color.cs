using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour
{
    [SerializeField] private int ColorValor;
    [SerializeField] private AudioClip Sonido_Pintura;

    public bool EsDeColor = false;
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
            var colorPersonaje = player.gameObject.GetComponent<Color_Personaje>();

            // Cambiar el color del jugador y reproducir el sonido
            colorPersonaje.CambiarColor(ColorValor);
            if (ColorValor != 3)
            {
                audioSource.PlayOneShot(Sonido_Pintura);
            }
        }
    }
}
