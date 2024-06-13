using UnityEngine;

public class Harry : MonoBehaviour
{
    public float flugGeschwindigkeit = 8f; // Geschwindigkeit des Fliegens nach oben oder unten
    public float vorwaertsGeschwindigkeit = 2f; // Langsame Vorwärtsbewegung
    public float schwerkraftFaktor = 2f; // Schwerkraftfaktor, um die Fallgeschwindigkeit zu erhöhen
    public Transform spawnPunkt; // Referenz zum Spawnpunkt
    private Rigidbody2D rb2d; // Rigidbody2D-Komponente
    private Transform kameraTransform;

    void Start()
    {
        // Hol dir die Rigidbody2D-Komponente des GameObjects
        rb2d = GetComponent<Rigidbody2D>();
        kameraTransform = Camera.main.transform;

        // Setze den Schwerkraftfaktor
        rb2d.gravityScale = schwerkraftFaktor;
    }

    void Update()
    {
        // Automatische langsame Vorwärtsbewegung in der 2D Welt (entlang der x-Achse)
        rb2d.velocity = new Vector2(vorwaertsGeschwindigkeit, rb2d.velocity.y);

        // Erhalte die vertikale Eingabe (Pfeil nach oben/unten)
        float vertikaleEingabe = Input.GetAxis("Vertical");

        // Bewege Harry basierend auf der vertikalen Eingabe nach oben oder unten
        // Diesmal in der y-Achse, passend für 2D
        rb2d.velocity = new Vector2(rb2d.velocity.x, vertikaleEingabe * flugGeschwindigkeit);
    }

    private void LateUpdate()
    {
        kameraTransform.position = new Vector3(transform.position.x, transform.position.y + 2.5f, -10);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Kollision erkannt mit: " + collision.gameObject.name); // Debug-Nachricht

        if (collision.gameObject.CompareTag("Stange"))
        {
            Debug.Log("Kollision mit Stange erkannt"); // Debug-Nachricht

            // Setze Harrys Position auf den Spawnpunkt zurück
            rb2d.velocity = Vector2.zero; // Setze die Geschwindigkeit auf Null, um jegliche Bewegung zu stoppen
            transform.position = spawnPunkt.position;

            // Optional: Setze die Kameraposition zurück
            kameraTransform.position = new Vector3(spawnPunkt.position.x, spawnPunkt.position.y + 2.5f, -10);

            Debug.Log("Harry zurückgesetzt auf Spawnpunkt: " + spawnPunkt.position); // Debug-Nachricht
        }
    }
}
