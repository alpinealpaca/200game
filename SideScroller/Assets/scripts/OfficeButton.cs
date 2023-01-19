using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TouchControlsKit;

public class OfficeButton : Interactable
{
    [SerializeField] private Sprite pressedButtonSprite; // active button sprite
    [SerializeField] private Sprite buttonSprite; //regular sprite again

    [SerializeField] private GameObject SecondOne; //Second red light :D
    [SerializeField] private Sprite pressedButtonSprite2; 
    [SerializeField] private Sprite buttonSprite2; 

    public NextLevelScreen NextLevelScreen;

    //public LevelSelectScreen LevelSelectScreen;//\\

    //safety checks
    private bool interactable = false;
    private bool doorOpened = false; //false = prompt showing, true = not showing

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        interactable = true;
        //sets the button bool to true to allow it to be pressed
        if (doorOpened == false)
        {
            // this will run the base funtion so that the interact prompt pops up and disappears
            base.OnTriggerEnter2D(collision);
            
        }
    }

    public override void OnTriggerExit2D(Collider2D collision)
    {
        if (doorOpened == true)
        {
            base.OnTriggerExit2D(collision);
            BackAway(); //close menu
            interactable = false;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = buttonSprite;
            SecondOne.GetComponent<SpriteRenderer>().sprite = buttonSprite2;
            doorOpened = false;

        }
    }


    private void Update()
    {
        // checks to see if the player presses E while in front of the button
        //if (Input.GetKeyDown(KeyCode.E) && interactable == true)
        if (TCKInput.GetAction("fireBtn", EActionEvent.Down) && interactable == true)
        {
            doorOpened = true; // press it, prompt turns off

            this.gameObject.GetComponent<SpriteRenderer>().sprite = pressedButtonSprite;
            SecondOne.GetComponent<SpriteRenderer>().sprite = pressedButtonSprite2;// changes the button to green
            NextLevel();
        }
        
        
    }

    public void NextLevel()
    {
        NextLevelScreen.Setup();
        //LevelSelectScreen.Setup(); //\\
    }

    public void BackAway()
    {
        NextLevelScreen.Setdown();
    }
}
