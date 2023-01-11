using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelSelectScreen : MonoBehaviour
{
    public bool ScreenSelect = false;

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Setdown(); 

        } 
    }

    
    public void Setup()
    {
        gameObject.SetActive(true);
        ScreenSelect = true;
        
    }

    public void Setdown()
    {
        gameObject.SetActive(false);
        ScreenSelect = false;
        
    }

    public void Button1()
    {
        SceneManager.LoadScene("Level_1");
        ScreenSelect = false;
    }

    public void Button2()
    {
        SceneManager.LoadScene("Level_2");
        ScreenSelect = false;
    }

    public void Button3()
    {
        SceneManager.LoadScene("Level_3");
        ScreenSelect = false;
    }


    public void ExitButton()
    {
        SceneManager.LoadScene("TitleScreen");
        ScreenSelect = false;
    }

    
}
