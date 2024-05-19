using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PasarNivel : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject CameraController;
    [SerializeField] private GameObject AudioController;
    [SerializeField] private int PasarANivel;
    [SerializeField] private int UltimoNivel;
    [SerializeField] private AudioClip Sonido_Pasar_Nivel;
    [SerializeField] private AudioClip Sonido_Final;

    [Header("Grid")]
    [SerializeField] private TilemapRenderer Mapa;
    [SerializeField] private TilemapRenderer Muro;
    [SerializeField] private TilemapRenderer Techo;
    [SerializeField] private TilemapRenderer Verdes;
    [SerializeField] private TilemapRenderer Verdes2;
    [SerializeField] private TilemapRenderer Azules;
    [SerializeField] private GameObject Cortina;
    [SerializeField] private GameObject Collider;
    [SerializeField] private GameObject Collider1;
    [SerializeField] private GameObject Collider2;
    [SerializeField] private GameObject Collider3;
    [SerializeField] private GameObject Collider4;
    [SerializeField] private GameObject Collider5;
    [SerializeField] private GameObject Collider6;
    [SerializeField] private GameObject Collider7;
    [SerializeField] private GameObject Collider8;
    [SerializeField] private GameObject Collider9;
    [SerializeField] private GameObject Collider10;
    [SerializeField] private GameObject Collider11;

    private BoxCollider2D bc;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerExit2D(Collider2D bc)
    {
        CameraController.gameObject.GetComponent<CamaraController>().ChangeLevel(PasarANivel);

        if (PasarANivel == UltimoNivel)
        {
            Mapa.material.color = new Color32(0, 255, 255, 255);
            Muro.material.color = new Color32(0, 255, 255, 255);
            Techo.material.color = new Color32(0, 255, 255, 255);
            Verdes.material.color = new Color32(0, 255, 255, 255);
            Verdes2.material.color = new Color32(0, 255, 255, 255);
            Azules.material.color = new Color32(0, 255, 255, 255);
            Cortina.gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 255, 255, 255);
            Collider.gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 255, 255, 255);
            Collider1.gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 255, 255, 255);
            Collider2.gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 255, 255, 255);
            Collider3.gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 255, 255, 255);
            Collider4.gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 255, 255, 255);
            Collider5.gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 255, 255, 255);
            Collider6.gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 255, 255, 255);
            Collider7.gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 255, 255, 255);
            Collider8.gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 255, 255, 255);
            Collider9.gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 255, 255, 255);
            Collider10.gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 255, 255, 255);
            Collider11.gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 255, 255, 255);
            AudioController.gameObject.GetComponentInParent<AudioSource>().Stop();
            AudioController.gameObject.GetComponentInParent<AudioSource>().PlayOneShot(Sonido_Final);
        }
        else 
        {
            Player.gameObject.GetComponent<Color_Personaje>().ResetColor();
            audioSource.PlayOneShot(Sonido_Pasar_Nivel);
        }
    }
}
