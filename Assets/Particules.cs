using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particules : MonoBehaviour
{
    public int speed;
    Rigidbody2D rb;
    private Vector3 dir;
    private int count;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        count = 0;
    }
    private void Update()
    {
        if (count == 0)
        {
            dir = (transform.position-Vector3.zero).normalized;
        }
        rb.velocity = dir * speed;
        if (count == 300)
        {
            Destroy(gameObject);
        } 
        count++;
    }
}
