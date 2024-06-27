/*Скрипт описывает работу главного меню и переключение сцен*/
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public GameObject settingPanel;
    public void PlayGame()
    {

        SceneManager.LoadSceneAsync(1);

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
        settingPanel.SetActive(false);

    }
}