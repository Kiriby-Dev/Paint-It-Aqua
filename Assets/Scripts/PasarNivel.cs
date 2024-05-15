using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasarNivel : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject CameraController;
    [SerializeField] private int PasarANivel;
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
    }
}
