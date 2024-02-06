using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    public int currentSprite;
    void ChangeSprite()
    {
        spriteRenderer.sprite = spriteArray[currentSprite];
        currentSprite++;
        if(currentSprite >= spriteArray.Length)
        {
            currentSprite = 0;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
