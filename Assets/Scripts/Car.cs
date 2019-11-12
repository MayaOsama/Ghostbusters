using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    static Animator anim;
    public float speed = 100.0f;
    public float rotationSpeed = 100.0f;
    public float timer = 0.0f;
    public float halt = 0.0f;
    private bool haltFinish = false;
    private int ghost = 0;
    private int human = 0;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (haltFinish == false)
        {
            halt += Time.deltaTime;
            if (((int)halt % 60) >= 5)
            {
                haltFinish = true;
            }
        }
        else
        {
            float translation = speed;
            translation *= Time.deltaTime;

            timer += Time.deltaTime;
            int seconds = (int)timer % 60;

            if (seconds < 7)
            {
                transform.Translate(translation, 0, 0);

            }

        }


        //float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        //rotation *= Time.deltaTime;
        //transform.Rotate(0, rotation, 0);
        //if (Input.GetButtonDown("Jump"))
        //{
        //    anim.SetTrigger("isShooting");
        //}

        //if (translation != 0)
        //{
        //    anim.SetBool("isRunning", true);
        //}
        //else
        //{
        //    anim.SetBool("isRunning", false);
        //}
    }
}
