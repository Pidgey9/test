using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDetect : MonoBehaviour
{
    public AudioSource soundPart;
    private int count;
    public int speed;
    Rigidbody2D rb;
    public int xpos;
    public MeshRenderer[] colorChild;
    private MeshRenderer color;
    private void Awake()
    {
        count = 0;
        rb = GetComponent<Rigidbody2D>();
        colorChild = this.GetComponentsInChildren<MeshRenderer>();
        color = GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        color.material = colorChild[2].material;
        if (soundPart.isPlaying)
        {
            color.material = colorChild[1].material;
        }
    }
    private void FixedUpdate()
    {
        if (soundPart.isPlaying)
        {
            if (count % 100 < 49)
            {
                rb.velocity = Vector2.up * speed;
            }
            if (count % 100 > 49)
            {
                rb.velocity = Vector2.down * speed;
            }
        }
        else
        {
            transform.position = new Vector2(xpos, 0);
        }
        count++;
    }
}
