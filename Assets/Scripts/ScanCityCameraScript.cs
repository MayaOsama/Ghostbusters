using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanCityCameraScript : MonoBehaviour
{
    Transform transform;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        timer = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            transform.Translate(0, 0,2);
        }
    }
}
