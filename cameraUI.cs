using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraUI : MonoBehaviour
{
    public Camera mainCamera;
    
    
    void cameraButtonClick()
    {
        if(gameObject.tag == "cameraButton1")
        {
            Debug.Log("cameraButton1");
        }

        else if (gameObject.tag == "cameraButton2")
        {
            Debug.Log("cameraButton2");
        }
    }
}
