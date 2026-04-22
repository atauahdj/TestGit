using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Second : MonoBehaviour
{
    public float speed;
    public Transform[] Runner;
    private int runnerEst = 0;
    private int runnerEstNext = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Runner[runnerEst].LookAt(Runner[runnerEstNext]);
        Debug.Log("Est: " + runnerEst);
        Debug.Log("EstNext" + runnerEstNext);
        if (Vector3.Distance(Runner[runnerEst].position, Runner[runnerEstNext].position) <= 0.1f)
        {
            runnerEst = (runnerEst + 1) % Runner.Length;
            runnerEstNext = (runnerEstNext + 1) % Runner.Length;
        }
        if(runnerEst >= Runner.Length)
        {
            
        }
        Runner[runnerEst].position = Vector3.MoveTowards(Runner[runnerEst].position, Runner[runnerEstNext].position, speed * Time.deltaTime);
    }
}
