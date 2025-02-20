using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imputhanlder : MonoBehaviour
{
    public bool inInteraction { get; private set; }


    //to do: Make input handler singleton class 
    void update()
    {
        inInteraction = OnTouchScreen() || OnMouseClick();
    }

    bool OnTouchScreen()
    {
        return Input.touchCount > 0;    
    }

    bool OnMouseClick()
    {
        return Input.GetMouseButtonDown(0);
    }
}
