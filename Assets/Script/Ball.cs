using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public int SpawnTimer;
    private Rigidbody2D ballRB;
    void Start()
    {
        ballRB = GetComponent<Rigidbody2D>();
        Invoke("SpawnBall", SpawnTimer);
    }
    void SpawnBall()
    {
        float rand = Random.Range(0, 4);

        if(rand == 1)
        {
            ballRB.AddForce(new Vector2(20, -15));
        } 
        else if(rand == 2)
        {
            ballRB.AddForce(new Vector2(-20, -15));
        }
        else if(rand == 3)
        {
            ballRB.AddForce(new Vector2(20, 15));
        }
        else
        {
            ballRB.AddForce(new Vector2(-20, 15));
        }
    }

    void ResetBall()
    {
        ballRB.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    void RestartGame()
    {
        ResetBall();
        Invoke("SpawnBall", 1);
    }

    void OnCollision (Collision2D coll) 
    {
        if(coll.collider.CompareTag("Player"))
        {
            Vector2 vel;
            vel.x = ballRB.velocity.x;
            vel.y = (ballRB.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3);
            ballRB.velocity = vel;
        }
    }
}
