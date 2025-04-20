using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] SpriteRenderer bgr;
    [SerializeField] float speed = 0.5f;

    void Update()
    {
        bgr.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}

