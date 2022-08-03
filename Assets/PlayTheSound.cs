using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTheSound : MonoBehaviour
{
    private AudioSource audioSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void Start()
    {
        audioSource.Play();
    }
}
