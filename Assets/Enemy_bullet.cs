using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 10;
    public Rigidbody2D rb;

    void Start()
    {
        Destroy(gameObject,1);
        rb.velocity = transform.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerLife player = hitInfo.GetComponent<PlayerLife>();
        if (player != null)
        {
            player.Takedamage(damage);
            Destroy(gameObject);
        }
        

    }

}

