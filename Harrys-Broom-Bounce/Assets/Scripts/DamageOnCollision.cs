using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnCollision : MonoBehaviour
{

    public GameObject harry;
    private void OnCollisionEnter2D(Collision2D collision){

        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth playerHealth = harry.GetComponent<PlayerHealth>();    
            if (playerHealth != null)
            {
                playerHealth.TakeDamage();
            }
            else
            {
                Debug.Log("PlayerHealth component not found on the Player GameObject");
            }
        }
        else
        {
            Debug.Log("Collision with non-Player object");
        }
            
        

    }
}
