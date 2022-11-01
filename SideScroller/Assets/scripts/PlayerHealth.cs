using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//

public class PlayerHealth : Health
{
    //public GameObject checkpoint;

    public GameOverScreen GameOverScreen;
    

    public override void HandleDamage(int damageValue)
    {
        base.HandleDamage(damageValue);

        //the death logic
        if (currentHealth <= 0)
        {
            //this.gameObject.transform.position = checkpoint.transform.position;
            //currentHealth = maxHealth;             

            GameOver();
            

            //Scene CurrentScene = SceneManager.GetActiveScene();
            //SceneManager.LoadScene(CurrentScene.name);
            //player.transform.position = respawnPoint.position;
        }
    }

    public void GameOver()
    {
        GameOverScreen.Setup();
    }





}
