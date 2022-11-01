using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public int cleanCount;

    public TextMeshProUGUI cleanCountText;

    ////////////////////////
    //public TextMeshProUGUI score;
    public TextMeshProUGUI highScore;
    public TextMeshProUGUI lastScore; //save for office
    public TextMeshProUGUI currentScore; //For Day Complete


    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        lastScore.text = PlayerPrefs.GetInt("LastScore", 0).ToString();
    }
    ////////////////////////

    public void Update()
    {
        cleanCountText.text = "" + cleanCount;
        currentScore.text = "" + cleanCount;
    }

    public void HandleCollectible(int collectibleValue)
    {
        cleanCount += collectibleValue;

        KeepScore();
    } //add score req to meet each level or lose - timer.cs

    ////////////////////////
    public void KeepScore()
    {
        int number = cleanCount;

        PlayerPrefs.SetInt("LastScore", number);
        cleanCountText.text = number.ToString();

        if (number > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", number);
            cleanCountText.text = number.ToString();
            Debug.Log("NEW SCORE");
        }
        
    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore");
        highScore.text = "0";
    }

}
