using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particules : MonoBehaviour
{
    public int speed;
    Rigidbody2D rb;
    private Vector3 dir;
    private int count;
    public AudioSource source;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        count = 0;
    }
    private void Update()
    {
        if(count == 0)
        {
            dir = (transform.position - Vector3.zero).normalized;
        }
        if (count == 300)
        {
            Destroy(gameObject);
        } 
        count++;
        if (Input.GetKey(KeyCode.A))
        {
            source.Play();
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = dir * speed;
    }
}
