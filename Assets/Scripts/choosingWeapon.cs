using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choosingWeapon : MonoBehaviour
{
    public static int gun = 0;
    public static int bomb = 0;
    public GameObject g;
    public GameObject b;

    public void activateGun()
    {
        bomb = 0;
        gun = 1;
        g.SetActive(true);
        b.SetActive(false);
    }
    public void activateBomb()
    {
        gun = 0;
        bomb = 1;
        g.SetActive(false);
        b.SetActive(true);

    }
}
