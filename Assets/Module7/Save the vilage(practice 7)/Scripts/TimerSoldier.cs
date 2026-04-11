using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TimerSoldier : MonoBehaviour
{
    public AudioSource spawn;
    public AudioSource nyam;
    public Button SoldierButton;
    public TMP_Text Score_soldier_unit;
    public int score2;
    public Image timer;
    private float currentTime = 1f;
    private bool timerRunning = false;
    public QuantitywheatScript scoreWheat;
    private bool BuyEnabled = true;
    // Start is called before the first frame update
    void Start()
    {
        SoldierButton = GetComponent<Button>();
    }
    void Update()
    {
        if(timerRunning)
        {
            if (timerRunning)
            {
                currentTime -= Time.deltaTime;
                SoldierButton.interactable = false;
                if (BuyEnabled)
                {
                    BuyEnabled = false;
                }
                if (currentTime >= 0f)
                {
                    timer.fillAmount = currentTime;
                }

                if (currentTime <= 0f)
                {
                    spawn.Play();
                    ++score2;
                    Score_soldier_unit.text = $"Quantity soldier: {score2}";
                    BuyEnabled = true;
                    currentTime = 1f;
                    timer.fillAmount = currentTime;
                    timerRunning = false;
                }
            }
        }
        else if (!timerRunning)
        {
            SoldierButton.interactable = true;
        }
        if (scoreWheat.score2 < 3f)
        {
            SoldierButton.interactable = false;
        }
    }
    public void BuySoldier()
    {
        if (BuyEnabled)
        {
            BuySoldierFunction();
        }
    }

    private void BuySoldierFunction()
    {
        if (scoreWheat.score2 >= 3f)
        {
            nyam.Play();
            timerRunning = true;
            scoreWheat.score2 = scoreWheat.score2 - 2f;
            Debug.Log(score2);
        }
    }
}
