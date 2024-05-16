using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] private float speed; // Velocidad de movimiento del jugador
    [SerializeField] private AudioClip Sonido_Movimiento;

    private AudioSource audioSource;
    private bool isMoving = false;
    private Rigidbody2D rb;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Si el jugador no está actualmente en movimiento, permitir la entrada del jugador
        if (rb.velocity.magnitude < 0.1f)
        {
            isMoving = false;
        }

        if (!isMoving)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.velocity = Vector2.up * speed;
                audioSource.PlayOneShot(Sonido_Movimiento);
                isMoving = true;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rb.velocity = Vector2.down * speed;
                audioSource.PlayOneShot(Sonido_Movimiento);
                isMoving = true;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rb.velocity = Vector2.left * speed;
                audioSource.PlayOneShot(Sonido_Movimiento);
                isMoving = true;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rb.velocity = Vector2.right * speed;
                audioSource.PlayOneShot(Sonido_Movimiento);
                isMoving = true;
            }
        }
    }
}
