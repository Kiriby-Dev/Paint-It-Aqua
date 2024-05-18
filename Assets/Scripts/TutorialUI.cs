using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialUI : MonoBehaviour
{
    [SerializeField] private GameObject tutorialUI;
    private bool estado = true;

    public void AlternarUI() 
    {
        estado = !estado;
        tutorialUI.SetActive(estado);
    }
}
