using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public float totalLevelTime = 60f; //work day timer
    public float currentLevelTime;

    //make the timer visible
    [SerializeField] TextMeshProUGUI countdownText;


   // public int PlayerScore = 0; //cleaning points!

    //public Text scoreUI;


    // Start is called before the first frame update
    void Start()
    {
        currentLevelTime = totalLevelTime;

        
    }

    // Update is called once per frame
    void Update()
    {
        currentLevelTime -= Time.deltaTime; // -= 1 * Time.deltaTime;
        countdownText.text = currentLevelTime.ToString("0");

        if (currentLevelTime <= 0f)
        {
            Debug.Log("End of Day"); //Finish. Go to Office.
            //Time.timeScale = 0f;
            currentLevelTime = 0; //stops negative numbers
        }
        if (currentLevelTime <= 10f)
        {
            countdownText.color = Color.red;
        }
        


        //scoreUI.text = PlayerScore.ToString();
        
    }

    //public void increasePlayerScore(int value)
    //{
    //    PlayerScore += value;
    //}

    public void Pause()
    {
        Time.timeScale = 0f;
    }

   // public void GameOver()
   // {
       // SceneManager.LoadScene("GameOver"); //make this scene + script
   // }
}
