using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daBad : MonoBehaviour
{
   public int losBr = 0;
    void Start()
    {
      
    }

    void Update()
    {
         if (losBr > 7)
        {
            Debug.Log("Izgubio");
        }
    }

    void OnTriggerEnter(Collider other)
    {

        gameObject.tag="daBad";
       // gameObject.SetActive(false);

        losBr++;
       

        Debug.Log("daBadDodir");
    }
}
