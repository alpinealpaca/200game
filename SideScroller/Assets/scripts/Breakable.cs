using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : Health 
{
    [SerializeField] private Sprite crackedBox; //sprite to display objects breaking
    [SerializeField] private GameObject brokenFX; //vfx feedback when breaks
    

    public override void HandleDamage(int damageValue)
    {
        base.HandleDamage(damageValue);

        this.gameObject.GetComponent<SpriteRenderer>().sprite = crackedBox;

        if (currentHealth <= 0)
        {
            Instantiate(brokenFX, gameObject.transform.localPosition, Quaternion.identity); //smoke poof
            Destroy(gameObject);


            GetComponent<Score>().AddScore();  // <----- THIS LINE HERE




        }
        




    }


}
