using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Challange8 : MonoBehaviour
{ 
    private bool work = false;
    private bool pointChanger;
    public float speed;
    bool Change = false;
    public Transform point1;
    public Transform point2;
    // Update is called once per frame
    void Start()
    {

    }
    void Update()
    {
        PressSpace();
        if (work)
        {
            if (pointChanger)
            {
                transform.position = Vector3.MoveTowards(transform.position, point2.position, speed);
                transform.Rotate(0, 0, 3);
                if (transform.position == point2.position)
                {
                    pointChanger = false;
                }
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, point1.position, speed);
                transform.Rotate(0, 0, -3);
                if (transform.position == point1.position)
                {
                    pointChanger = true;
                }
            }
        }
    }
    private void PressSpace()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Change)
            {
                work = true;
            }
            else
            {
                work = false;
            }
            Change = !Change;
        }
    }
}

