using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerColor : MonoBehaviour
{
    public Material[] materials;
    Renderer rend;
    private int human = 0;
    private int ghost = 0;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterials = materials;
        human = choosingPlayer.humanact;
        ghost = choosingPlayer.ghostact;
        if (ghost == 1)
        {
            rend.materials[0].color = Color.white;
            rend.materials[1].color = Color.white;

        }
        else
        {
            rend.materials[0].color = Color.black;
            rend.materials[1].color = Color.black;
        }
    }
}
