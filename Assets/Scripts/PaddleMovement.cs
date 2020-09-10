using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public bool isLeft;
    private float movement;
    public int speed = 10;

    private void Start()
    {
    }

    void Update()
    {
        if (isLeft == true)
        {
            print("Left paddle selected");
            movement = Input.GetAxis("VerticalLeft");
        }
        else
        {
            print("Right paddle selected");
            movement = Input.GetAxis("VerticalRight");
        }
        transform.position = transform.position + new Vector3(0, movement, 0) * Time.deltaTime * speed;
        
    }
}
