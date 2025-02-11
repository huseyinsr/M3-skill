using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bit : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public bool state = false;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (state)
        {
            spriteRenderer.color = Color.blue;
        }
        else
        {
            spriteRenderer.color = Color.red;
        }
    }
    private void OnMouseUp()
    {
        state = !state;
    }
}