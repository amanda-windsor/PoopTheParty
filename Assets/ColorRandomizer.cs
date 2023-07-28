using UnityEngine;

public class ColorRandomizer : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Randomize the color when the object is instantiated
        RandomizeColor();
    }

    private void RandomizeColor()
    {
        // Generate a random color
        Color randomColor = new Color(Random.value, Random.value, Random.value);

        // Apply the random color to the sprite renderer
        spriteRenderer.color = randomColor;
    }
}
