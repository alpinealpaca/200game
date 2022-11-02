using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class NextLevelScreen : MonoBehaviour
{
    public void Setup()
    {
        gameObject.SetActive(true);
        
    }

    public void Setdown()
    {
        gameObject.SetActive(false);

    }

    public void NextButton()
    {
        SceneManager.LoadScene("Level_2");

    }


    public void ExitButton()
    {
        SceneManager.LoadScene("TitleScreen");
        
    }
}
