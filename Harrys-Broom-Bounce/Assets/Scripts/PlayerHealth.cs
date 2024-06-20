using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public static event Action OnPlayerDamaged;
    public static event Action OnPlayerDeath;

    public float health, maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }


    public void TakeDamage(){
        health -= 1;
        OnPlayerDamaged?.Invoke();
        Debug.Log("minus heart");

        if(health <= 0){
            health = 0;

            SceneManager.LoadScene("Dead");
            Debug.Log("Your are dead");
            OnPlayerDeath?.Invoke();
        }
    }
}
