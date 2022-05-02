using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnStartTouch : MonoBehaviour
{
    public Animator animator;
    [SerializeField]
    private Button red;
    
    private bool macka = false;
    private int i = 0;

    void Start()
    {
        
    }
    void ker ()
    {
        macka = true;
    }

    void Update()
    {
        if (Input.touchCount>0) 
        {
            animator.SetTrigger("tStart");
            ker ();
        }
        if (macka == true)
        {
            i++;
            if(i > 90)
            {
                macka = false;

                red.gameObject.SetActive(true);

            }
        }
    }
}

