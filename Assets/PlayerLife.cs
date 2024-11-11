using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{

    [SerializeField] GameObject Player;

    public Rigidbody2D rb; 
   
    public int health = 100;
   
    public void Takedamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die() 
    {
        rb.bodyType = RigidbodyType2D.Static;
    }
    private void RestartLevel() // Starta om scenen när vi dör
    {
        if (health <= 0)
        {
            SceneManager.LoadScene(0);
        }
        
    }
}
