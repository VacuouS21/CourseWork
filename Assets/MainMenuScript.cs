using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    private GameObject Levels;

    public Text name;
    public Text light;
    public Text medium;
    public Text hight;
    public Text ballBoss;
    public Text markBoss;
    public void Start()
    {
        name.text += GlobalRandomNumber.name;
        light.text += GlobalRandomNumber.firstLevel;
        medium.text += GlobalRandomNumber.secondLevel;
        hight.text += GlobalRandomNumber.thiirdLevel;
        ballBoss.text += GlobalRandomNumber.bossLevel;
        markBoss.text += GlobalRandomNumber.bossCheck;

    }
    public void PlayGame()
    {
        SceneManager.LoadScene(3);
    }
    public void ExitGames()
    {
        Debug.Log("Игра закрылась");
        Application.Quit();
    }

    public void ViewInfo(GameObject gameObject)
    {
        Levels = gameObject;
        Levels.SetActive(!Levels.activeSelf);

    }
}
