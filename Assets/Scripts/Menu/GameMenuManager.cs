/*Скрипт описывает работу меню из игры*/
using UnityEngine;

public class GameMenuManager : MonoBehaviour
{

    public GameObject settingPanel;
    private bool isPaused = false;


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }

    }
    public void PlayGame()
    {

        Resume();

    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void SettingPanel()
    {

        settingPanel.SetActive(true);
    }
    public void ExitPanel()
    {
        Resume();

    }
    public void Pause()
    {
        settingPanel.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void Resume()
    {
        settingPanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
}
