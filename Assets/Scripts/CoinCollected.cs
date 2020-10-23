using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollected : MonoBehaviour
{
    public Text display;
    private int total = 0;

    public void AddCoin(int coins = 1)
    {
        total = total + coins;
        //display.text = total.ToString();
        display.text = "x " + total;
    }
    public void Addstar(int stars = 5)
    {
        total = total = stars;
        display.text = "x" + total;
    }
}
