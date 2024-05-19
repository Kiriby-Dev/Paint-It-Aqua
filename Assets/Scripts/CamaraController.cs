using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    [SerializeField] private List<CinemachineVirtualCamera> virtualCameras; // Lista de cámaras para cada nivel
    public int currentLevel = 0; // Nivel actual

    // Start is called before the first frame update
    private void Awake()
    {
        // Desactiva todas las Cinemachine Virtual Cameras excepto la del nivel actual
        for (int i = 0; i < virtualCameras.Count; i++)
        {
            virtualCameras[i].gameObject.SetActive(i == currentLevel);
        }
    }

    // Método para cambiar de nivel y de Cinemachine Virtual Camera
    public void ChangeLevel(int newLevel)
    {
        // Desactiva la Cinemachine Virtual Camera del nivel actual
        virtualCameras[currentLevel].gameObject.SetActive(false);

        // Cambia al nuevo nivel
        currentLevel = newLevel;

        // Activa la Cinemachine Virtual Camera del nuevo nivel
        virtualCameras[currentLevel].gameObject.SetActive(true);
    }
}
