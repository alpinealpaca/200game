using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    //health values
    public int currentHealth;
    public int maxHealth;

    //heart images
    public Image[] hearts; //array
    public Sprite fullHeart;
    public Sprite emptyHeart;


    // Update is called once per frame
    void Update()
    {
        //make sure amount of hearts displayed is the same as max health <3 <3 <3
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
       
       UpdateHealth(); //method

    }

//-------------Functions--------------//

    public virtual void HandleDamage(int damageValue)
    {
        currentHealth -= damageValue;
    }

    void UpdateHealth()
    {
        for (int i = 0; i < hearts.Length; i++)  //for every item/heart in this array, we'll loop through this code 4 times.
        {
            if (i < currentHealth)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < maxHealth)
            {
                hearts[i].enabled = true;
            }
            else{
                hearts[i].enabled = false;
            }
        }     
    }
            
    


}



