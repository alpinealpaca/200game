using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Pause : MonoBehaviour
{
    public GameObject PauseScreen;
    private bool Paused = false;

    public bool ScreenSelect = false; //From levelselectscreen script

    // Start is called before the first frame update
    void Start()
    {
        PauseScreen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape") && ScreenSelect == false)
        {
            if (Paused == false)
            {
                Time.timeScale = 0f;
                PauseScreen.gameObject.SetActive(true);
                Paused = true;
                
            }
            else
            {
                Resume();
            }
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        PauseScreen.gameObject.SetActive(false);
        Paused = false;
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("TitleScreen");
        Time.timeScale = 1f;
    }
}
