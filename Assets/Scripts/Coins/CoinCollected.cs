using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollected : MonoBehaviour
{
    public Text display;
    public static int total = 0;

    private void Start()
    {
        display.text = "x" + total;
    }

    public void AddCoin(int coins = 1)
    {
        total = total + coins;
        //display.text = total.ToString();
        display.text = "x " + total;
    }
}
