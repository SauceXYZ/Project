using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 1f;

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0, 0, Time.deltaTime * rotationSpeed, Space.Self);
    }
}
