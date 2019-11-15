using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showPlayer : MonoBehaviour
{
    private static int ghost;
    private static int hum;
    public GameObject g;
    public GameObject h;
    // Start is called before the first frame update
    void Start()
    {
        ghost = choosingPlayer.ghostact;
        hum = choosingPlayer.humanact;
        if(ghost == 1 && hum == 0)
        {
            g.SetActive(true);
            h.SetActive(false);
        }
        if (ghost == 0 && hum == 1)
        {
            h.SetActive(true);
            g.SetActive(false);
        }
    }
}
