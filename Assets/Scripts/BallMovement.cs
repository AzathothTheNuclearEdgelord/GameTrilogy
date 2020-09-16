using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private float speedX = 5;
    private float speedY = 5;

    void Update()
    {
        transform.Translate(speedX * Time.deltaTime, speedY * Time.deltaTime, 0);
        DeathTrigger();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Wall")
        {
            speedY = -speedY;
        }
        
        if (other.gameObject.tag == "Paddle")
        {
            speedX = -speedX;
        }
    }

    private void DeathTrigger()
    {
        if (transform.position.x >= 9)
        {
            PongManager.rightScoreIncrease = true;
            PositionReset();
        }

        if (transform.position.x <= -9)
        {
            PongManager.leftScoreIncrease = true;
            PositionReset();
        }
    }

    private void PositionReset()
    {
        transform.position = new Vector3(0, 0, 0);
    }
}
