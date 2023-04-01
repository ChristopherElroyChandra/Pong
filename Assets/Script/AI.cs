using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public Transform ball;
    public float paddleSpeed = 10.0f;
    public float boundY = 4f;
    public float Delays = 0.01f;
    float Timer;
    
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer > Delays)
        {
            Move();
            Timer -= Delays;
        }
    }

    void Move()
    {
        if (transform.position.y < ball.position.y)
        {
            transform.Translate(Vector3.up * Time.deltaTime * paddleSpeed);
        }
        else if (transform.position.y > ball.position.y)
        {
            transform.Translate(Vector3.down * Time.deltaTime * paddleSpeed);
        }

        var pos = transform.position;
        if (pos.y > boundY)
        {
            pos.y = boundY;
        }
        else if (pos.y < -boundY)
        {
            pos.y = -boundY;
        }
        transform.position = pos;
    }
}   
