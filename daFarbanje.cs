using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daFarbanje : MonoBehaviour
{
    public int winBr = 0;

    void Start()
    {
      
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

        gameObject.tag="daFarbanje";
        //gameObject.SetActive(false);

        winBr++;
        //Debug.Log(winBr);
        if (winBr > 35)
        {
            Debug.Log("Pobeda");
        }

        Debug.Log("daDodir");
    }
}
