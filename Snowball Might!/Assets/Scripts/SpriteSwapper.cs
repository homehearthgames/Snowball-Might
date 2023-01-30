using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwapper : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    [SerializeField] SnowHandler snowHandler;

    [SerializeField] Sprite sprite1, sprite2, sprite3;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float snowAmount = snowHandler.CurrentSnow / snowHandler.MaxSnow;
        switch (snowAmount)
        {
            case <= .32f:
                spriteRenderer.sprite = sprite3;
                break;
            case <= .65f:
                spriteRenderer.sprite = sprite2;
                break;
            case >= .66f:
                spriteRenderer.sprite = sprite1;
                break;
            default:
                spriteRenderer.sprite = sprite1;
                break;
        }
    }
}
