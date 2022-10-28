using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    public GameObject impactEffect;

    public PlayerHealth playerHealth;


    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    



    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);//
        }
        //impact effect
        GameObject instanceImpactEffect = Instantiate(impactEffect, transform.position, transform.rotation) ;
        Destroy(instanceImpactEffect, 1);

        if(hitInfo.CompareTag("Player"))
        {
           // PlayerHealth player = GameObject.FindGameObjectWithTag("Player");
            //player.TakeDamage(damage);

            Destroy(gameObject);
        }

    }  



}


/////////////////////////////////////////////////////
//private Vector3 oldVelocity;

//store the laser's velocity every frame -> use this data during collisions to reflect
// void FixedUpdate () //fixed = after physics
//{
//  oldVelocity = GetComponent<Rigidbody2D>().velocity;
//}

// when a collision happens
//void OnCollisionEnter(Collision collision)
//{
// get the point of contact
//  ContactPoint contact = collision.contacts[0];

// reflect our old velocity off the contact point's normal vector
//        Vector2 reflectedVelocity = Vector2.Reflect(oldVelocity, contact.normal);

// assign the reflected velocity back to the rigidbody
//GetComponent<Rigidbody2D>().velocity = reflectedVelocity;
// rotate the object by the same ammount we changed its velocity
//Quaternion rotation = Quaternion.FromToRotation(oldVelocity, reflectedVelocity);
//transform.rotation = rotation * transform.rotation;
//}
/////////////////////////////////////////////////////