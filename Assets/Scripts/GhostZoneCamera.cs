using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostZoneCamera : MonoBehaviour
{
    Transform transform;
    float timer;
   // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        timer = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0 )
        {
            timer -= Time.deltaTime;
            transform.Translate(0, 0, -0.5f);
        }
    }
}
