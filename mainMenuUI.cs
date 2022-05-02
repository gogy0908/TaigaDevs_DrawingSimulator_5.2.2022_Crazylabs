using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainMenuUI : MonoBehaviour
{
    public Button GameStart;
    public Button Settings;
    public Button Quit;

    void Start(){
        GameStart.onClick.AddListener(onButtonGameStart);
        Settings.onClick.AddListener(onButtonSettings);
        Quit.onClick.AddListener(onButtonQuit);
    }

    void onButtonGameStart(){
        Debug.Log("Game Start Button");
        SceneManager.LoadScene("LVL1");
    }

    void onButtonSettings(){
        Debug.Log("Settings Button");
    }

    void onButtonQuit(){
        Debug.Log("Quit Button");
        Application.Quit();
    }   
}
