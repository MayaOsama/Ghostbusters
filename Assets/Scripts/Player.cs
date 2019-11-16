using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    static Animator anim;
    public float speed = 100.0f;
    public float rotationSpeed = 100.0f;
    public float timer = 0.0f;
    public float halt = 0.0f;
    private bool haltFinish = false;
    private int ghost = 0;
    private int human = 0;
    public int gun = 0;
    public int bomb = 0;
    private AudioSource[] audioSources;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        ghost = choosingPlayer.ghostact;
        human = choosingPlayer.humanact;
        gun = choosingWeapon.gun;
        bomb = choosingWeapon.bomb;
        audioSources = GetComponents<AudioSource>();

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
            int seconds =(int) timer % 60;

            if(human == 1)
            {
                if(seconds < 8)
                {
                    if(seconds <= 3)
                    {
                       anim.SetBool("isRunning", true);
                       transform.Translate(0, 0, translation);
                    }
                    else if(seconds > 3 && seconds <= 4)
                    {
                        anim.SetBool("isRunning", false);

                    } else if(seconds > 4)
                    {
                        anim.SetBool("isRunning", true);
                        transform.Translate(0, 0, translation);

                    }
                }
                else
                {
                    anim.SetBool("isRunning", false);

                }

            }
            else if(ghost == 1)
            {
                anim.SetBool("isRunning", true);

                if (seconds < 7)
                {
                    transform.Translate(0, 0, translation);

                }
                else
                {
                    anim.SetBool("isRunning", false);

                }
            }
            if (seconds == 9)
            {
                if(bomb == 1)
                {
                    anim.SetTrigger("isThrowing");

                }
                else if(gun == 1)
                {
                    anim.SetTrigger("isShooting");
                }

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

    void Shoot()
    {
        audioSources[0].Play();

    }

    void Throw()
    {
        audioSources[1].Play();

    }
}
