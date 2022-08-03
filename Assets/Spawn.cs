using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject particules;
    public int cadence;
    private int count;
    private void Update()
    {   
        if (count % cadence == 0)
        {
            Instantiate(particules, transform);
        }
        count++;
    }
}
