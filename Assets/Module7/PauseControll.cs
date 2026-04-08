using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseControll : MonoBehaviour
{
    public AudioSource audioo;
    private bool paused;
    public void GamePause()
    {
        if (paused)
        {
            audioo.Play();
            Time.timeScale = 1;
        }
        else
        {
            audioo.Pause();
            Time.timeScale = 0;
        }
        paused = !paused;
    }

}
