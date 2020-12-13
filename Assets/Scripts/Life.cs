using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    

    public RawImage apple1;
    public RawImage apple2;
    public RawImage apple3;
   

    private int lifeRemaining;
    public Transform playeTrans;

    

    void Update()
    {
        lifeRemaining = lifeRemaining - 1;
    }


    public Texture2D appleFull;
    public Texture2D appleEmpty;
    public Text display;

    private int apples = 3;

    public void HurtAndReset()
    {

        apples = apples - 1;

        
        if (apples == 3)
        {

            apple1.enabled = true;
            apple2.enabled = true;
            apple3.enabled = true;
        }
        else if (apples == 2)
        {
            apple1.enabled = true;
            apple2.enabled = true;
            apple3.enabled = false;
        }
        else if (apples == 1)
        {
            apple1.enabled = true;
            apple2.enabled = false;
            apple3.enabled = false;
        }
        else
        {
            apple1.enabled = false;
            apple2.enabled = false;
            apple3.enabled = false;
     
            SceneManager.LoadScene("Dead");
        }
    }
}
