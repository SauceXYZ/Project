using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneyprops : MonoBehaviour
{
    public AudioClip coinSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<CoinCollected>().AddCoin();
            GetComponent<AudioSource>().PlayOneShot(coinSound);
            //gameObject.SetActive(false);
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Animator>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

    }
    
}
