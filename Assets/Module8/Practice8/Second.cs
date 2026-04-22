using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Second : MonoBehaviour
{
    public Transform stick;
    public float speed;
    public Transform[] Runner;
    public Transform[] Hands;
    private int Hand = 0;
    private int HandNext = 1;
    private int runnerEst = 0;
    private int runnerEstNext = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Runner[runnerEst].LookAt(Runner[runnerEstNext]);
        Runner[runnerEstNext].LookAt(Runner[runnerEst]);
        if (Vector3.Distance(Runner[runnerEst].position, Runner[runnerEstNext].position) <= 0f)
        {
            runnerEst = (runnerEst + 1) % Runner.Length;
            Hand = (Hand + 1) % Hands.Length;
            runnerEstNext = (runnerEstNext + 1) % Runner.Length;
            HandNext = (HandNext + 1) % Hands.Length;
            stick.SetParent(Runner[runnerEst]);
        }
        if(runnerEst >= Runner.Length)
        {
            
        }
        Runner[runnerEst].position = Vector3.MoveTowards(Runner[runnerEst].position, Runner[runnerEstNext].position, speed * Time.deltaTime);
        stick.position = Hands[Hand].position;
    }
}
