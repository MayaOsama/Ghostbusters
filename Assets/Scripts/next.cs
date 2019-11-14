using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    private static int isghost;
    private static int ishum;
    private static int isgun;
    private static int isbomb;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void back2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    public void backToMen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
    public void startScene()
    {
        isghost = choosingPlayer.ghostact;
        ishum = choosingPlayer.humanact;
        if ((isghost == 1 && ishum == 0) || (isghost == 0 && ishum == 1))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    public void startSampScene()
    {
        isgun = choosingWeapon.gun;
        isbomb = choosingWeapon.bomb;
        if ((isgun == 1 && isbomb == 0) || (isgun == 0 && isbomb == 1))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
