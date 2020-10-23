using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewCheckpoint : MonoBehaviour
{
    public Deathbox tomber;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            tomber.checkpoint = gameObject.transform;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
