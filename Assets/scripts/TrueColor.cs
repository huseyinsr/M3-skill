using UnityEngine;

public class TrueColor : MonoBehaviour
{
    [SerializeField] private MyPixel myPixel; // Sleep prefab hiernaartoe in de Inspector

    private MyPixel[] pixels;

    // Resolutie van het grid (bijv. 64x64)
    [SerializeField] private int width = 64;
    [SerializeField] private int height = 64;

    private int currentIndex = 0;

    void Start()
    {
        pixels = new MyPixel[width * height];

        // Bereken pixelgrootte via orthographicSize & aspectRatio
        float cameraHeight = 2f * Camera.main.orthographicSize;
        float cameraWidth = cameraHeight * Camera.main.aspect;

        float pixelWidth = cameraWidth / width;
        float pixelHeight = cameraHeight / height;

        Vector2 startPos = new Vector2(-cameraWidth / 2 + pixelWidth / 2, -cameraHeight / 2 + pixelHeight / 2);

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                int index = y * width + x;
                Vector2 pos = startPos + new Vector2(x * pixelWidth, y * pixelHeight);
                MyPixel pixel = Instantiate(myPixel, pos, Quaternion.identity, this.transform);
                pixel.transform.localScale = new Vector3(pixelWidth, pixelHeight, 1f);
                pixels[index] = pixel;
            }
        }
    }

    void Update()
    {
        if (pixels == null || pixels.Length == 0) return;

        // Geef de volgende pixel een random kleur (TrueColor = 24-bit RGB)
        if (currentIndex < pixels.Length)
        {
            float r = Random.value;
            float g = Random.value;
            float b = Random.value;
            pixels[currentIndex].color = new Color(r, g, b);
            currentIndex++;
        }
    }
}
