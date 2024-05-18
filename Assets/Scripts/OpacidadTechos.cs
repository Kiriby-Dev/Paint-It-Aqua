using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class OpacidadTechos : MonoBehaviour
{
    private TilemapRenderer tilemap;

    private void Start()
    {
        tilemap = GetComponent<TilemapRenderer>();
        tilemap.material.color = new Color32(255, 255, 255, 255);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Activa la opacidad
            tilemap.material.color = new Color32(255, 255, 255, 130);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Restaura la opacidad original
            tilemap.material.color = new Color32(255, 255, 255, 255);
        }
    }
}
