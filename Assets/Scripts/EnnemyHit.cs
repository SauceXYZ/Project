﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyHit : MonoBehaviour
{
    public Transform checkpoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.GetComponent<Life>().HurtAndReset();
            collision.GetComponent<Transform>().position = new Vector2(checkpoint.position.x, checkpoint.position.y);
            collision.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }

}
