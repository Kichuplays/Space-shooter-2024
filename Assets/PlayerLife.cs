using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
   
    public Rigidbody2D rb; 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap")) 
        {
            Die();
        }
    }

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
        SceneManager.LoadScene(0);
    }
}
