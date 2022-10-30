using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    [SerializeField] private int damageValue;
    [SerializeField] private Sprite deadSprite; 
    [SerializeField] private GameObject deathFX; //vfx feedback when breaks

    //decl of enum public bnlahblah enemystate=currentstate

    public override void HandleDamage(int damageValue)
    {
        base.HandleDamage(damageValue);

        //state machine
        //if alive...

        if (currentHealth <= 0)
        {
            Instantiate(deathFX, gameObject.transform.localPosition, Quaternion.identity); //smoke poof
            this.gameObject.GetComponent<SpriteRenderer>().sprite = deadSprite;
            
        }



    }



}
