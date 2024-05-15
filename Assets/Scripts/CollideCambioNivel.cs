using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideCambioNivel : MonoBehaviour
{
    private BoxCollider2D bc;
    private bool isExiting = false;
    [SerializeField] float waitTime;

    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D bc)
    {
        // Marcar que el objeto está saliendo del collider
        isExiting = true;

        // Iniciar la corutina para esperar y luego desactivar isTrigger
        StartCoroutine(DisableTriggerAfterDelay());
    }

    IEnumerator DisableTriggerAfterDelay()
    {
        // Esperar el tiempo especificado
        yield return new WaitForSeconds(waitTime);

        // Si el objeto sigue fuera del collider, desactivar isTrigger
        if (isExiting)
        {
            bc.isTrigger = false;
        }
    }
}
