using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    public GameObject PauseWindow;
    public bool pause;
    public Image Pause;
    public Sprite OnPause;
    public Sprite OffPause;
    public SoundScript snd;
    // Start is called before the first frame update
    void Start()
    {
        PauseSwitch();
    }

    public void PauseSwitch()
    {
        if (pause) 
        {
            Pause.sprite = OnPause;
            Time.timeScale = 0f;
            PauseWindow.SetActive(true);
            snd.bMusic.Pause();
            snd.bNature.Pause();
        }
        else
        {
            Pause.sprite = OffPause;
            Time.timeScale = 1.0f;
            PauseWindow.SetActive(false);
            snd.bMusic.Play();
            snd.bNature.Play();
        }
        pause = !pause;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
