using UnityEngine;

public class MyPixel : MonoBehaviour
{
    [Range(0, 255)] public byte ByteR;
    [Range(0, 255)] public byte ByteG;
    [Range(0, 255)] public byte ByteB;

    public GameObject Pixel;  // Child GameObject met SpriteRenderer
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        if (Pixel != null)
        {
            spriteRenderer = Pixel.GetComponent<SpriteRenderer>();
        }
        else
        {
            Debug.LogError("Pixel GameObject is niet toegewezen!");
        }
    }

    void Update()
    {
        if (spriteRenderer != null)
        {
            string colorCode = $"#{ByteR:X2}{ByteG:X2}{ByteB:X2}";
            // Debug.Log(colorCode);

            if (ColorUtility.TryParseHtmlString(colorCode, out Color newColor))
            {
                spriteRenderer.color = newColor;
            }
            else
            {
                Debug.LogError("Ongeldige hex kleur: " + colorCode);
            }
        }
    }

    public void SetColor(Color32 kleur)
    {
        ByteR = kleur.r;
        ByteG = kleur.g;
        ByteB = kleur.b;
    }
}
