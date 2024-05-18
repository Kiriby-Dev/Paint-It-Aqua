using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PasarNivel : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject CameraController;
    [SerializeField] private int PasarANivel;
    [SerializeField] private int UltimoNivel;

    [Header("Grid")]
    [SerializeField] private TilemapRenderer Mapa;
    [SerializeField] private TilemapRenderer Muro;
    [SerializeField] private TilemapRenderer Techo;

    private BoxCollider2D bc;

    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerExit2D(Collider2D bc)
    {
        CameraController.gameObject.GetComponent<CamaraController>().ChangeLevel(PasarANivel);
        Player.gameObject.GetComponent<Color_Personaje>().ResetColor();

        if (PasarANivel == UltimoNivel) 
        {
            Mapa.material.color = new Color32(0, 255, 255, 255);
            Muro.material.color = new Color32(0, 255, 255, 255);
            Techo.material.color = new Color32(0, 255, 255, 255);
        }
    }
}
