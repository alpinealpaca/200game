using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public GameObject corpse;
    public GameObject corpse2;
    public GameObject corpse3;

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(corpse, transform.position, Quaternion.identity);
        Instantiate(corpse2, transform.position, Quaternion.identity);
        Instantiate(corpse3, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
