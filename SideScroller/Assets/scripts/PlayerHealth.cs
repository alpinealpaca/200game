using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    public GameObject checkpoint;


    public override void HandleDamage(int damageValue)
    {
        base.HandleDamage(damageValue);

        //the death logic
        if (currentHealth <= 0)
        {
            this.gameObject.transform.position = checkpoint.transform.position;
            currentHealth = maxHealth;             //^\\
                                                   //replay, reset scene


            //Scene CurrentScene = SceneManager.GetActiveScene();
            //SceneManager.LoadScene(CurrentScene.name);
            //player.transform.position = respawnPoint.position;


        }
    }





}
