using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimerWave : MonoBehaviour

{
    public AudioSource FightSound;
    public GameObject LoseWindow;
    public Image timer;
    public TMP_Text QuantityEnemy;
    private float currentTime = 1f;
    public float MaxTime;
    private bool timerRunning = false;
    private bool Fight;
    public int quantityEnemy = 3;
    private int previousQuantityEnemy;
    public TimerSoldier soldier;

    void Start()
    {
        timer = GetComponent<Image>();
        currentTime = MaxTime;
        timerRunning = true;
    }
    void Update()
    {
        if (timerRunning)
        {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0f)
            {
                Fight = true;
                timerRunning = false;
            }
            else if (currentTime >= 0f)
            {
                timer.fillAmount = currentTime / MaxTime;
                QuantityEnemy.text = $"Quantity enemy: {quantityEnemy}";
            }
        }

        if (Fight)
        {
            previousQuantityEnemy = quantityEnemy;
            soldier.score2 = soldier.score2 - quantityEnemy;
            Fight = false;
            FightSound.Play();
            if (soldier.score2 < 0)
            {
                Time.timeScale = 0;
                Debug.Log(soldier.score2);
                LoseWindow.SetActive(true);
            }
            else if(soldier.score2 >= 0)
            {
                previousQuantityEnemy = previousQuantityEnemy + 3;
                quantityEnemy = previousQuantityEnemy;
                Debug.Log("You win!");
                MaxTime = MaxTime + 15f;
                currentTime = MaxTime;
                timerRunning = true;
            }
        }
    }
}
