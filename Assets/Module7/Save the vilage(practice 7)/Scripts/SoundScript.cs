using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundScript : MonoBehaviour
{
    [Header("UI Elements")]
    public Scrollbar mainBar;
    public Scrollbar musicBar;
    public Scrollbar natureBar;
    [Header("Audio Elements")]
    public AudioSource click;
    public AudioSource bMusic;
    public AudioSource bNature;
    // Start is called before the first frame update

    public void Click()
    {
        click.Play();
    }
    public void MusicVolume()
    {
        bMusic.volume = musicBar.value;
    }
    public void NatureVolume()
    {
        bNature.volume = natureBar.value;
    }
    public void MasterVolume()
    {
        bMusic.volume = mainBar.value;
        bNature.volume = mainBar.value;
    }
    // Update is called once per frame
    void Update()
    {
        MasterVolume();
    }
}
