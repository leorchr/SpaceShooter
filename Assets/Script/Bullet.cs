using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 20;
    public Rigidbody2D rb;
    void Start()
    {
        // déplace le projectile
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Asteroid enemy = collision.GetComponent<Asteroid>();
        if (enemy != null)
        {
            Debug.Log("Un ennemi a été touché");
            enemy.TakeDamage(damage);
        }

        Destroy(gameObject); //détruit le projectile dès qu'il touche un gameObject
    }
}
