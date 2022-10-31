using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    public float rotationsPerMinute = 10.0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 0, 6.0f * rotationsPerMinute * Time.deltaTime);
    }
}
