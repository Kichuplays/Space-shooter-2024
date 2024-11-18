using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject enemys;
    public int maxhealth = 100;
    public void TakeDamage(int damage)
    {
        maxhealth -= damage;
        if (maxhealth <= 0)
        {
            Die();
        }
    }
    
    
    
    void Die()
    {
        Scoremanager score = FindAnyObjectByType<Scoremanager>();
        Destroy(gameObject);
    }
    private void Update()
    {
        
    }
}

