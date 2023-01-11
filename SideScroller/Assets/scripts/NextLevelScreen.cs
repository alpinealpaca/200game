using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class NextLevelScreen : MonoBehaviour
{
    

    public LevelSelectScreen LevelSelectScreen;

    public void Setup()
    {
        gameObject.SetActive(true);
        
    }

    public void Setdown()
    {
        gameObject.SetActive(false);
        LevelSelectScreen.Setdown();
    }

    public void NextButton()
    {
        //SceneManager.LoadScene("Level_2"); //Now leads into LevelSelectScreen.cs instead
        LevelSelectScreen.Setup();
        
    }


    public void ExitButton()
    {
        SceneManager.LoadScene("TitleScreen");
        
    }

}
