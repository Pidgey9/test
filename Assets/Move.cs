using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector2 move;
    Rigidbody2D rb;
    public int speed;
    public int rspeed;
    float rota;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        move = new Vector2(h, v);
        rota = Input.GetAxis("Rotation");
    }
    private void FixedUpdate()
    {
        rb.velocity = move * speed;
        rb.angularVelocity = -rota * rspeed;
    }
}
