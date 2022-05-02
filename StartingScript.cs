using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingScript : MonoBehaviour
{
    public GameOverScreen gameOverLose;
    public GameOverScreen gameOverWin;
    public int BrFarbi = 0;
    public int BrQuadova = 0;
    public int BrBad = 0;
    private int i = 0;
       
    public GameObject[] myGameObjects = new GameObject[0];
    public GameObject[] myGameObjectsQuad = new GameObject[0];
    public GameObject[] myGameObjectsBad = new GameObject[0];
        

    void Start()
    {
        
    }

    void Update()
    {

        i++;
        if(i > 60)
        {
            i=0;
            myGameObjectsBad = GameObject.FindGameObjectsWithTag("daBad");
            myGameObjectsQuad = GameObject.FindGameObjectsWithTag("daQuad");
            myGameObjects = GameObject.FindGameObjectsWithTag("daFarbanje");
            foreach (GameObject item in myGameObjects)
            {
                BrFarbi ++;

            }

            foreach (GameObject item in myGameObjectsQuad)
            {
                BrQuadova ++;
            }
            foreach (GameObject item in myGameObjectsBad)
            {
                BrBad ++;
            }

             Debug.Log(BrFarbi);
         
            if(BrBad > 4)
            {
                Debug.Log("gubitak");
                gameOverLose.Setup();
                gameOverWin.Close();
            }
            if(BrFarbi > 37)
            {
                Debug.Log("pobeda");
                gameOverWin.Setup();
                gameOverLose.Close();
            }
            //if (BrQuadova > 100)
            //{
              //  BrQuadova = 0;
           // }

               /* BrFarbi = 0;
                BrQuadova= 0;
                BrBad= 0;
                */

        }
        if (i == 30)
        {
            
            BrQuadova = 0;
            BrFarbi = 0;
            BrBad = 0;
            
        } 
    }
}