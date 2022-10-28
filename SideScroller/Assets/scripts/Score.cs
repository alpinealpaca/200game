using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public int Points;
    public TextMeshProUGUI ScoreText;
    //public static Score scoremanager;
    


    public void AddScore()
    {
        Points++;
        ScoreText.text = Points.ToString();
    }

    
}
       