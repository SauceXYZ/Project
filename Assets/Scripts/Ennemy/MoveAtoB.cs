using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MoveAtoB : MonoBehaviour
{
    public Transform aPoint;
    public Transform bPoint;

    public float speed = 1f;

    private bool versPointA = true;

    // Update is called once per frame
    void Update()
    {
        Vector2 goal;
        if (versPointA)
        {
            goal = aPoint.position;
        }
        else
        {
            goal = bPoint.position;
        }
        float step = speed * Time.deltaTime;
        Vector2 move = Vector2.MoveTowards(transform.position, goal, step);
        transform.position = move;

        if (Vector2.Distance(move, goal) < 0.001f)
        {
            versPointA = !versPointA;
        }
    }
}
