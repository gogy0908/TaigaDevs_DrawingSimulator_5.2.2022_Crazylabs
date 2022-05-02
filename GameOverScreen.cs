using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameOverScreen : MonoBehaviour
{
    public Button RestartButton;
    public Button MainMenuButton;

    void Start(){

        RestartButton.onClick.AddListener(onButtonRestartGS);
        MainMenuButton.onClick.AddListener(onButtonMainMenuGS);
    }

    public void Setup()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public void onButtonRestartGS()
    {
        SceneManager.LoadScene("LVL1");
    }

    public void onButtonMainMenuGS()
    {
        SceneManager.LoadScene("MAIN_MENU");
    }
}
