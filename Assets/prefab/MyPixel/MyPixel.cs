using UnityEngine;

public class MyPixel : MonoBehaviour
{
    public Byte ByteR;  // Byte voor Rood
    public Byte ByteG;  // Byte voor Groen
    public Byte ByteB;  // Byte voor Blauw
    public GameObject Pixel;  // GameObject voor de sprite
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        if (Pixel != null)
        {
            spriteRenderer = Pixel.GetComponent<SpriteRenderer>();
        }
    }



    void Update()
    {
            if (ByteR != null && ByteG != null && ByteB != null && Pixel != null)
            {
                // Declare the colorCode variable before using it
                string colorCode = "#" + ByteR.getHex() + ByteG.getHex() + ByteB.getHex();
                 print(colorCode);



            if (UnityEngine.ColorUtility.TryParseHtmlString(colorCode, out Color newColor))
                {
                    spriteRenderer.color = newColor;
                }
                else
                {
                    Debug.LogError("Ongeldige hex kleur: " + colorCode);
                }
            }
            else
            {
                Debug.LogError("Een van de Byte-objecten of de Pixel ontbreekt!");
            }


    }
}
