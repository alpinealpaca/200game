using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class DayOverScreen : MonoBehaviour
{
    //public TextMeshProUGUI cleanCountText;

    public void Setup(int Timegone)
    {
        gameObject.SetActive(true);
        //cleanCountText.text = Score.ToString() + " Points";
        Time.timeScale = 0f;

    }




    public void OfficeButton()
    {
        SceneManager.LoadScene("Office");
        Time.timeScale = 1f;
    }


    public void ExitButton()
    {
        SceneManager.LoadScene("TitleScreen");
        Time.timeScale = 1f;
    }

}
