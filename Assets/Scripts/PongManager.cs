using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PongManager : MonoBehaviour
{
    int leftScore;
    int rightScore;

    public Text rightText;
    public Text leftText;

    public GameObject Ball;

    private void Start()
    {
        Ball = GameObject.Find("BallBase");
    }

    private void Update()
    {
        /*
        print(leftScore);
        print(rightScore);
        */

        if (Ball.transform.position.x >= 8) 
        {
            LeftScoreIncrease();
        }
        if (Ball.transform.position.x <= -8) 
        {
            RightScoreIncrease();
        }
    }

    public void LeftScoreIncrease()
    {
        leftScore++;
        leftText.text = leftScore.ToString();
    }

    public void RightScoreIncrease()
    {
        rightScore++;
        rightText.text = rightScore.ToString();
    }
}
