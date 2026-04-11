using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerVillager : MonoBehaviour
{
    public AudioSource spawn;
    public Button VillagerButton;
    public TMP_Text Score_villager_unit;
    public int score;
    public Image timer;
    private float currentTime = 1f;
    private bool timerRunning = false;
    public QuantitywheatScript scoreWheat;
    // Start is called before the first frame update
    void Start()
    {
        VillagerButton = GetComponent<Button>();
        
    }
    void Update()
    {
        if(timerRunning)
        {
            VillagerButton.interactable = false;
            if (timerRunning)
            {
                currentTime -= Time.deltaTime;

                if (currentTime >= 0f)
                {
                    timer.fillAmount = currentTime;
                }

                if (currentTime <= 0f)
                {
                    ++score;
                    Score_villager_unit.text = $"Quantity villager: {score}";
                    spawn.Play();
                    currentTime = 1f;
                    timer.fillAmount = currentTime;
                    timerRunning = false;
                }
            }
        }
        else if (!timerRunning)
        {
            VillagerButton.interactable = true;
        }
        if(scoreWheat.score2 < 2f)
        {
            VillagerButton.interactable = false;
        }
    }
    public void BuyVillager()
    {
        if(scoreWheat.score2 >= 2f)
        {
            timerRunning = true;
            scoreWheat.score2 = scoreWheat.score2 - 2f;
            scoreWheat.interval = scoreWheat.interval - 0.05f;
            Debug.Log(score);
        }
    }
}
