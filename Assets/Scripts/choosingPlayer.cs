using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choosingPlayer : MonoBehaviour
{
    public static int humanact = 0;
    public static int ghostact = 0;
    public GameObject g;
    public GameObject h;

    public void activateGhost()
    {
        humanact = 0;
        ghostact = 1;
        g.SetActive(true);
        h.SetActive(false);
    }
    public void activateHuman()
    {
        ghostact = 0;
        humanact = 1;
        g.SetActive(false);
        h.SetActive(true);

    }



}
