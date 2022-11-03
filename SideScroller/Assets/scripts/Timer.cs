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

    public DayOverScreen DayOverScreen;
    int timeCount = 0;
    public GameOverScreen GameOverScreen;

    public int scoreReq;
    public int currentScore;
    public GameObject player;

    void Start()
    {
        currentLevelTime = totalLevelTime;
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        currentLevelTime -= Time.deltaTime; // -= 1 * Time.deltaTime;
        countdownText.text = currentLevelTime.ToString("0"); //("Time: 0")

        if (currentLevelTime <= 0f)
        {
            //Debug.Log("End of Day"); 
            currentLevelTime = 0; //stops negative numbers.

            currentScore = player.GetComponent<ItemManager>().cleanCount;

            if (currentScore >= scoreReq)
            {
                DayOver();
            }
            else
            {
                GameOverScreen.Setup();
            }

        }
        if (currentLevelTime <= 10f)
        {
            countdownText.color = Color.red;
        }
    }


    public void DayOver()
    {
        DayOverScreen.Setup(timeCount);
    }
}