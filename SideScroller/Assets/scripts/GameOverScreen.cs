using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    //public TextMeshProUGUI cleanCountText;
    

    public void Setup()
    {
        gameObject.SetActive(true);
        //cleanCountText.text = Score.ToString() + " Points";
        
        Time.timeScale = 0f;

    }




    public void RestartButton()
    {
        SceneManager.LoadScene("Level_2");
        Debug.Log("Reset");
        Time.timeScale = 1f;
    }


    public void ExitButton()
    {
        SceneManager.LoadScene("TitleScreen");
        Time.timeScale = 1f;
    }

}
