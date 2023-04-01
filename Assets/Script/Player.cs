using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public KeyCode Up;
    public KeyCode Down;
    public float speed;
    public float boundY;
    private Rigidbody2D PlayerRB;

    void Start () 
    {
        PlayerRB = GetComponent<Rigidbody2D>();
    }

    void Update () 
    {
        var vel = PlayerRB.velocity;
        if (Input.GetKey(Up)) 
        {
            vel.y = speed;
        }
        else if (Input.GetKey(Down)) 
        {
            vel.y = -speed;
        }
        else 
        {
            vel.y = 0;
        }

        PlayerRB.velocity = vel;

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
