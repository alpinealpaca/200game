using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAttack : MonoBehaviour
{
    [SerializeField] private int damage;
    //[SerializeField] private float bounceForce = 1f;  //too bouncy in space


    //logic for jumping on things
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //jumping on breakables
        if(collision.gameObject.CompareTag("Breakable"))
        {
            //deal damage to object with bounce
            collision.gameObject.GetComponent<Breakable>().HandleDamage(damage);
            //this.GetComponentInParent<Rigidbody2D>().AddForce(new Vector2(0, bounceForce), ForceMode2D.Impulse);
        }

        //jumping on breakables
       // if(collision.gameObject.CompareTag("Enemy"))
     //   {
            //enemy jump on
            //collision.gameObject.GetComponent<EnemyHealth>().HandleDamage(damage);
      //      this.GetComponentInParent<Rigidbody2D>().AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
       // }

    }




}
