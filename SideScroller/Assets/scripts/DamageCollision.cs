using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollision : MonoBehaviour
{
    public int damageValue;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>().HandleDamage(damageValue);

            //Scene CurrentScene = SceneManager.GetActiveScene();
            //SceneManager.LoadScene(CurrentScene.name);
            //player.transform.position = respawnPoint.position;


        }

    }
}
