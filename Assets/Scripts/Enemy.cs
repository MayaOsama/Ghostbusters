using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    static Animator anim;
    public float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        int seconds = (int)timer % 60;

        if (seconds == 15)
        {
            anim.SetTrigger("isShooting");

        }

    }
}
