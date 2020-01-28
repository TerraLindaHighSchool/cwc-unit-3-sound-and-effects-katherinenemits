﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // moves the object and background to the left
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
