using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    void Start()
    {
        // Optional: Initialisierungslogik
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OnTriggerEnter2D called with: " + collision.gameObject.name);
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player detected. Switching scene...");
            SceneManager.LoadScene("LevelSelector");
        }
    }

    void Update()
    {
        // Optional: Update-Logik
    }
}
