using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeMaker : Interactable
{

    /*[SerializeField] private Sprite TheCoffeeMug;

    private bool Drinking = false;

    private bool interactable = false;
    private bool CoffeeNearby = false; //false = prompt showing, true = not showing



    public override void OnTriggerEnter2D(Collider2D collision)
    {
        interactable = true;
        //sets the button bool to true to allow it to be pressed
        if (CoffeeNearby == false)
        {
            // this will run the base funtion so that the interact prompt pops up and disappears
            base.OnTriggerEnter2D(collision);

        }
    }

    public override void OnTriggerExit2D(Collider2D collision)
    {
        if (CoffeeNearby == true)
        {
            base.OnTriggerExit2D(collision);
            //BackAway(); //close menu
            interactable = false;
            CoffeeNearby = false;

            CoffeeMug.Setup();
        }
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && interactable == true)
        {
            Drinking = true; 

        }
    }*/
}
