using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;

public class Basiclife : MonoBehaviour
{
    private int lifeRemaining;
    public int maxLife = 5;
    public Transform playeTrans;

    // Start is called before the first frame update
    void Start()
    {
        lifeRemaining = maxLife; 
    }

    // Update is called once per frame
    void Update()
    {
        lifeRemaining = lifeRemaining - 1;
    }

    private void FixedUpdate()
    {


    }
}
