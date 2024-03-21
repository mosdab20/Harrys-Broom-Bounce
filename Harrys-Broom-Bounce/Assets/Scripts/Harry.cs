using UnityEngine;

public class Harry : MonoBehaviour
{
    public float flySpeed = 6f; // Geschwindigkeit des Fliegens nach oben oder unten
    public float forwardSpeed = 2f; // Langsame Vorwärtsbewegung
    private Rigidbody2D rb2d; // Rigidbody2D-Komponente

    void Start() {
        // Hol dir die Rigidbody2D-Komponente des GameObjects
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update() {
        // Automatische langsame Vorwärtsbewegung in der 2D Welt (entlang der x-Achse)
        rb2d.velocity = new Vector2(forwardSpeed, rb2d.velocity.y);

        // Erhalte die vertikale Eingabe (Pfeil nach oben/unten)
        float verticalInput = Input.GetAxis("Vertical");

        // Bewege Harry basierend auf der vertikalen Eingabe nach oben oder unten
        // Diesmal in der y-Achse, passend für 2D
        rb2d.velocity = new Vector2(rb2d.velocity.x, verticalInput * flySpeed);
    }
}
