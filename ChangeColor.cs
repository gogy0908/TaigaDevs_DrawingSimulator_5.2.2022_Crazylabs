using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
   
    [SerializeField]
    private Button red;
    [SerializeField]
    private Button green;
    [SerializeField]
    private Button blue;
    [SerializeField]
    private Animator anim;

    public int i=0;
    void Start()
    {
   

    }
    void enableButton(){

        red.gameObject.SetActive(true);

    }

    void Update()
    {
        if (Input.touchCount >0){
            int a=0;
            if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime < 2){
                a++;
            }

            if (a == 1){

                if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1){
                    
                    if(i<1){
                        Debug.Log("not playing");
                        enableButton();
                        i++;
                    }
                }
                else 
                    Debug.Log("playing");
            }
        }
    }
}