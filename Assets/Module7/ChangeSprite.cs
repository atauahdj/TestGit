using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour
{
    //public Sprite newSprite;
    public float MaxTime;
    private float currentTime;
    private Image img;
    void Start()
    {
        img = GetComponent<Image>();
        currentTime = MaxTime;
    }
    public void Update()
    {
        currentTime -= Time.deltaTime;
        if(currentTime <= 0f)
        {
            currentTime = MaxTime;
        }
        if(currentTime >= 0f)
        {
            img.fillAmount = currentTime / MaxTime;
        }
        //img.sprite = newSprite;
        //img.color = Color.magenta;
        
    }
}
