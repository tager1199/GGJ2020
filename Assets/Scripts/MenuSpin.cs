﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSpin : MonoBehaviour
{
    // Start is called before the first frame update
    public float xSpeed = 0.0f;
    public float ySpeed = 0.0f;
    public float zSpeed = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(
         xSpeed * Time.deltaTime,
         ySpeed * Time.deltaTime,
         zSpeed * Time.deltaTime
        );
    }
}
