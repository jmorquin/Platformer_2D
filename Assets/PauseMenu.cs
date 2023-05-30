using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PauseMenu : MonoBehaviour

{
    public static bool GameIsPause = false;
    public GameObject PauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Escape"))

        {
            if (GameIsPause)

            {
                Resume();

            }


            else

            {
                Pause();
            }


        }
    }

    public void Resume()
    {
        Debug.Log("resume");
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }

    void Pause()
    {
        Debug.Log("Pause");
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }

    public void LoadMenu()

    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu"); 
    }

    public void QuitGame()

    {
        Application.Quit();
    }
}
