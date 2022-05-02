using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugMenuUI : MonoBehaviour
{
    public bool state = false;
    public debugUI UI;

    public void onButtonClick()
    {
        if(state == false)
        {
            UI.Setup();
            state = true;
        }
        else if(true)
        {
            UI.Close();
            state = false;
        }
    }
}
