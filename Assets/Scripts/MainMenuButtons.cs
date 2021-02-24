using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public Transform mainMenu;
    public Transform levelsMenu;
    public Transform level1SubMenu;

    public void GoToLevelsMenu()
    {
        levelsMenu.gameObject.SetActive(true);
        mainMenu.gameObject.SetActive(false);
    }

    public void GoToLevel1SubMenu()
    {
        level1SubMenu.gameObject.SetActive(true);
        levelsMenu.gameObject.SetActive(false);
    }

    public void BackToMainMenu()
    {
        mainMenu.gameObject.SetActive(true);
        levelsMenu.gameObject.SetActive(false);
    }

    public void BackToLevelsMenu()
    {
        levelsMenu.gameObject.SetActive(true);
        level1SubMenu.gameObject.SetActive(false);
    }

    public void LoadTestLevel1()
    {
        SceneManager.LoadScene("TestLevel1");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
