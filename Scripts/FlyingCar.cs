using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingCar : MonoBehaviour
{
    private AudioSource audioSources;

    // Start is called before the first frame update
    void Start()
    {
        audioSources = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Sound()
    {
        audioSources.Play();

    }
}
