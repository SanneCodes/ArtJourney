using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public bool journey = true;
    public static bool clicked = false;
    public Sprite newSprite;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        Debug.Log("Mouse Clicked");
        clicked = true;

        if (journey)
        {
            Debug.Log("Changing Sprite");
            if (spriteRenderer != null && newSprite != null)
            {
                spriteRenderer.sprite = newSprite;
            }
            else
            {
                Debug.LogError("SpriteRenderer or newSprite is not assigned. Please assign them in the Inspector.");
            }
        }
    }
}




