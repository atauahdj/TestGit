using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinScript : MonoBehaviour
{
    public TimerVillager win;
    public QuantitywheatScript wheatScore;
    public GameObject WinWindow;
    public TMP_Text ConditionsText;
    private float previousScore2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ConditionsText.text = $"Win conditions: {wheatScore.score2}/300 wheat";
        if (wheatScore.score2 >= 300f)
        {
            WinWindow.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
