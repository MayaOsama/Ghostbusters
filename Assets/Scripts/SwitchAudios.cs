using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAudios : MonoBehaviour
{

    public AudioSource ghostbusters;
    public AudioSource youshouldbedancing;
    public Animator viewersAnimator;
    // Start is called before the first frame update
    void Start()
    {
        ghostbusters.enabled = true;
        youshouldbedancing.enabled = true;
        ghostbusters.Play();
        youshouldbedancing.Stop();
        viewersAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ghostbusters.Stop();
            youshouldbedancing.Play();
            viewersAnimator.SetBool("isDancing", true);
            
        }
    }
}
