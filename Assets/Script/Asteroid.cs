using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed = 5f;
    public int health = 100;
    void Update()
    {
        transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
    }
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die(); //détruit l'ennemi quand il n'a plus de vie
        }
    }

    void Die()
    {
        Debug.Log("Asteroid hit");
        Destroy(gameObject);
    }
}
