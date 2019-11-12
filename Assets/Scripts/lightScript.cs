using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightScript : MonoBehaviour
{
    public Light lt1;
    private float timer = 0.0f;
    Color c1 = new Color(1f, 0, 0);
    Color c2 = new Color(0, 1f, 0);
    void Start()
    {
        lt1 = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        int currentSec = (int)timer % 60;
        if (currentSec >= 12 & currentSec <=17)
        {
            lt1.color = c1;

        }
        else
        {
            if (currentSec >= 17)
            {
                lt1.color = c2;
            }
        }
        timer += Time.deltaTime;
    }
}
