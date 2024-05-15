using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Puertas : MonoBehaviour
{
    [SerializeField] private int ColorValor;
    [SerializeField] private GameObject player;

    private TilemapCollider2D tilemap_collider;
    private TilemapRenderer tilemap;

    // Start is called before the first frame update
    void Start()
    {
        tilemap_collider = GetComponent<TilemapCollider2D>();
        tilemap = GetComponent<TilemapRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.gameObject.GetComponent<Color_Personaje>().ColorPersonaje == ColorValor) 
        {
            tilemap_collider.enabled = false;
            tilemap.material.color = new Color32(255, 255, 255, 130);//Activa Opacidad
        }
        else 
        {
            tilemap_collider.enabled = true;
            tilemap.material.color = new Color32(255, 255, 255, 255);//Desactiva Opacidad
        }
    }
}
