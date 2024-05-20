using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;
using System.Collections;

public class DollyTrackSceneChange : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera virtualCamera; // La cámara virtual de Cinemachine
    [SerializeField] private CinemachineSmoothPath dollyPath; // El camino del Dolly
    [SerializeField] private string nextSceneName; // Nombre de la siguiente escena
    [SerializeField] private Animator animator;

    private CinemachineTrackedDolly trackedDolly;

    private void Start()
    {
        // Obtener la referencia al TrackedDolly de la cámara virtual
        trackedDolly = virtualCamera.GetCinemachineComponent<CinemachineTrackedDolly>();
    }

    private void Update()
    {
        // Verificar si el TrackedDolly ha alcanzado el final del recorrido
        Debug.Log("Path Position: " + trackedDolly.m_PathPosition);
        Debug.Log("Path Length: " + dollyPath.PathLength);

        if (trackedDolly.m_PathPosition >= 1)
        {
            animator.SetTrigger("T_Out");
            StartCoroutine(WaitAndChangeScene(5f));
        }
    }

    private IEnumerator WaitAndChangeScene(float waitTime)
    {
        Debug.Log("Waiting for " + waitTime + " seconds before changing scene.");
        yield return new WaitForSeconds(waitTime);
        ChangeScene();
    }

    private void ChangeScene()
    {
        Debug.Log("Changing scene to " + nextSceneName);
        SceneManager.LoadScene(nextSceneName);
    }
}
