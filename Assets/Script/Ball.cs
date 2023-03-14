using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D ballRB;

    void SpawnBall()
    {
        float rand = Random.Range(0, 2);

        if(rand < 1)
        {
            ballRB.AddForce(new Vector2(20, -15));
        } 
        else 
        {
            ballRB.AddForce(new Vector2(-20, -15));
        }
    }

    void Start()
    {
        ballRB = GetComponent<Rigidbody2D>();
        Invoke("SpawnBall", 2);
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
        if(coll.collider.CompareTag("Player 1"))
        {
            Vector2 vel;
            vel.x = ballRB.velocity.x;
            vel.y = (ballRB.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3);
            ballRB.velocity = vel;
        }

        if(coll.collider.CompareTag("Player 2"))
        {
            Vector2 vel;
            vel.x = ballRB.velocity.x;
            vel.y = (ballRB.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3);
            ballRB.velocity = vel;
        }
    }
}
