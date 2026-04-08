using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AudioAndSpriteScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip clip;
    private AudioSource audioo;
    public Sprite newSprite;
    private Image img;
    void Start()
    {
        img = GetComponent<Image>();
        audioo = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void ChangeSprite()
    {
        img.sprite = newSprite;
        //img.color = Color.magenta;
    }
    public void ChangeSound()
    {
        audioo.clip = clip;
        audioo.Play();
    }
    public void PauseSound()
    {
        if (audioo.isPlaying)
        {
            audioo.Pause();
        }
        else
        {
            audioo.Play();
        }
    }
    
}
