using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    private int apples = 5;

    public RawImage apple1;
    public RawImage apple2;
    public RawImage apple3;
    public RawImage apple4;
    public RawImage apple5;

    public Texture2D appleFull;
    public Texture2D appleEmpty;

    public void HurtAndReset()
    {
        apples = apples - 1;

        if (apples == 5)
        {
            apple1.enabled = true;
            apple2.enabled = true;
            apple3.enabled = true;
            apple4.enabled = true;
            apple5.enabled = true;
        }
        else if (apples == 4)
        {
            apple1.enabled = true;
            apple2.enabled = true;
            apple3.enabled = true;
            apple4.enabled = true;
            apple5.enabled = false;
        }
        else if (apples == 3)
        {
            apple1.enabled = true;
            apple2.enabled = true;
            apple3.enabled = true;
            apple4.enabled = false;
            apple5.enabled = false;
        }
        else if (apples == 2)
        {
            apple1.enabled = true;
            apple2.enabled = true;
            apple3.enabled = false;
            apple4.enabled = false;
            apple5.enabled = false;
        }
        else if (apples == 1)
        {
            apple1.enabled = true;
            apple2.enabled = false;
            apple3.enabled = false;
            apple4.enabled = false;
            apple5.enabled = false;
        }
        else
        {
            apple1.enabled = false;
            apple2.enabled = false;
            apple3.enabled = false;
            apple4.enabled = false;
            apple5.enabled = false;

            // GameOver
        }
    }
}
