using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{
    public int cadence;
    public float rayon;
    private int count;
    private void Awake()
    {
        count = 0;
    }
    private void Update()
    {
        if (count % cadence == 0)
        {
            transform.position = Random.insideUnitCircle * rayon;
        }
        count++;
    }
}
