using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // Velocidad de movimiento del jugador
    private bool isMoving = false;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Si el jugador no está actualmente en movimiento, permitir la entrada del jugador
        if (rb.velocity == Vector2.zero) 
        {
            isMoving = false;
        }

        if (!isMoving)
        {
            // Si se presiona la tecla de flecha hacia arriba y el jugador no está actualmente en movimiento
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                // Mover hacia arriba
                rb.velocity = Vector2.up * speed;
                isMoving = true; // El jugador está en movimiento
            }
            // Si se presiona la tecla de flecha hacia abajo y el jugador no está actualmente en movimiento
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                // Mover hacia abajo
                rb.velocity = Vector2.down * speed;
                isMoving = true; // El jugador está en movimiento
            }
            // Si se presiona la tecla de flecha hacia la izquierda y el jugador no está actualmente en movimiento
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                // Mover hacia la izquierda
                rb.velocity = Vector2.left * speed;
                isMoving = true; // El jugador está en movimiento
            }
            // Si se presiona la tecla de flecha hacia la derecha y el jugador no está actualmente en movimiento
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                // Mover hacia la derecha
                rb.velocity = Vector2.right * speed;
                isMoving = true; // El jugador está en movimiento
            }
        }
    }
}
