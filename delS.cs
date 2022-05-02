using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class delS : MonoBehaviour
{
    public Button sett;
    void Start()
    {
        sett.onClick.AddListener(buttonSettClicked);
    }
    void buttonSettClicked()
    {
        gameObject.SetActive(false);
    }
    
    void Update()
    {
        
    }
}
