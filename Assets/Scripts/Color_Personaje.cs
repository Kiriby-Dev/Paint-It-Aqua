using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Color_Personaje : MonoBehaviour
{
    public int ColorPersonaje => colorPersonaje;
    private Dictionary<int, bool> colorStates = new Dictionary<int, bool>();

    [Header("Sprites Colores")]
    [SerializeField] private Sprite blanco;
    [SerializeField] private Sprite azul;
    [SerializeField] private Sprite verde;
    [SerializeField] private Sprite aqua;

    private int colorPersonaje = 0;
    private SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarColor(int color)
    {
        if (!colorStates.ContainsKey(color))
        {
            colorStates[color] = false;
        }

        if (colorStates[color])
        {
            colorPersonaje -= color;
            colorStates[color] = false;
        }
        else
        {
            colorPersonaje += color;
            colorStates[color] = true;
        }
        TransformarColor();
    }

    public void ResetColor() 
    {
        colorPersonaje = 0;
        foreach (var color in colorStates.Keys.ToList())
        {
            colorStates[color] = false;
        }
        TransformarColor();
    }

    private void TransformarColor() 
    {
        Sprite nuevoSprite = blanco;
        switch (colorPersonaje) 
        {
            case 0:
                nuevoSprite = blanco;
                break;
            case 1:
                nuevoSprite = verde;
                break;
            case 2:
                nuevoSprite = azul;
                break;
            case 3:
                nuevoSprite = aqua;
                break;
        }
        sprite.sprite = nuevoSprite;
    }
}
