using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostZoneCamera : MonoBehaviour
{
    Transform transform;
   // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < 950)
        {
            transform.Translate(0, 0, -1f);
        }
    }
}
