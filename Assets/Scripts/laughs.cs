using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laughs : MonoBehaviour
{
    public AudioSource laugh;
    public AudioClip hum;
    public AudioClip ghost;
    public AudioClip click;

    public void clickOn()
    {
        laugh.PlayOneShot(click);
    }
    public void ghostL()
    {
        laugh.PlayOneShot(ghost);
    }
    public void humanL()
    {
        laugh.PlayOneShot(hum);
    }

}
