using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 


public class debugUI : MonoBehaviour
{

    public Paintable crtanjeUI;
    
    public Camera mainCamera;
    public Camera Camera1;
    public Camera Camera2;
    public Camera Camera3;

    public GameObject BrushDefault;
    public GameObject BrushRed;
    public GameObject BrushGreen;
    public GameObject BrushBlue;

    public Button MainC;
    public Button C1;
    public Button C2;
    public Button C3;

    public Button MD;
    public Button M1;
    public Button M2;
    public Button M3;

    public Button RestartLevelButton;
    public Button MainMenuButton;

    public Paintable paintSurface;

    void Start(){

        MainC.onClick.AddListener(onButtonMainCClick);

        C1.onClick.AddListener(onButtonC1Click);

        C2.onClick.AddListener(onButtonC2Click);

        C3.onClick.AddListener(onButtonC3Click);

        M1.onClick.AddListener(onButtonM1Click);

        M2.onClick.AddListener(onButtonM2Click);
        
        M3.onClick.AddListener(onButtonM3Click);

        MD.onClick.AddListener(onButtonMDefault);

        RestartLevelButton.onClick.AddListener(onButtonRestart);

        MainMenuButton.onClick.AddListener(onButtonMainMenu);
    }

    public void Setup()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        Debug.Log("ZATVARAJ");
        gameObject.SetActive(false);
    }

    void onButtonMainCClick(){
        Debug.Log("Main Camera");

        paintSurface.CameraInUse = mainCamera;

        mainCamera.enabled = true;
        Camera1.enabled = false;
        Camera2.enabled = false;
        Camera3.enabled = false;
    }

    void onButtonC1Click(){
        Debug.Log("Camera1");

        paintSurface.CameraInUse = Camera1;

        mainCamera.enabled = false;
        Camera1.enabled = true;
        Camera2.enabled = false;
        Camera3.enabled = false;
    }

    void onButtonC2Click(){
        Debug.Log("Camera2");

        paintSurface.CameraInUse = Camera2;

        mainCamera.enabled = false;
        Camera1.enabled = false;
        Camera2.enabled = true;
        Camera3.enabled = false;
    }

    void onButtonC3Click(){
        Debug.Log("Camera3");

    paintSurface.CameraInUse = Camera3;

        mainCamera.enabled = false;
        Camera1.enabled = false;
        Camera2.enabled = false;
        Camera3.enabled = true;
    }

    void onButtonM1Click(){
        Debug.Log("Material1");
        crtanjeUI.Brush = BrushRed;
    }

    void onButtonM2Click(){
        Debug.Log("Material2");
        crtanjeUI.Brush = BrushGreen;
    }

    void onButtonM3Click(){
        Debug.Log("Material3");
        crtanjeUI.Brush = BrushBlue;
    }


    void onButtonMDefault(){
        Debug.Log("Default");
        crtanjeUI.Brush = BrushDefault;
    }

    void onButtonMainMenu(){
        Debug.Log("Main Menu");
       // SceneManager.LoadScene("MAIN MENU");
    }

    void onButtonRestart(){
        Debug.Log("Restart");
       // SceneManager.LoadScene("LEVEL");
    }
}