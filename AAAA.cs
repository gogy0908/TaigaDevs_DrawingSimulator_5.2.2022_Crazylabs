using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AAAA : MonoBehaviour
{
    public Button sett;
    // Start is called before the first frame update
    void Start()
    {
        sett.onClick.AddListener(buttonSettClicked);
    }
    void buttonSettClicked()
    {
        gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}