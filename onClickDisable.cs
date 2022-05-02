using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onClickDisable : MonoBehaviour
{
    void Update()
    {
        
        if (Input.touchCount >0 ){

             gameObject.SetActive(false);

        }

    }
}
