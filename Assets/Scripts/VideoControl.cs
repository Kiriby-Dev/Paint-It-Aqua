using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoControl : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        // Suscribe al evento loopPointReached
        videoPlayer.loopPointReached += EndReached;
    }

    // Método que se ejecuta cuando el video ha terminado de reproducirse
    void EndReached(VideoPlayer vp)
    {
        // Cambia a la siguiente escena
        SceneManager.LoadScene("Menu_Inicial");
    }
}
