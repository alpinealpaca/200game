using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //loading scenes in this

public class MainMenu : MonoBehaviour
{
    public string levelToLoad;

    public void LoadLevel()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void QuitGame()
    {
        Application.Quit();
        print("quit game");
    }
}
