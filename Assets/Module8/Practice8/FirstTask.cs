using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTask : MonoBehaviour
{
    public Vector3[] points;
    public float speed;
    private int currentPoint = 1;
    private bool forward = true;

    void Start()
    {
            transform.position = points[0];
    }

    void Update()
    {
        if (points.Length == 0) return;
        if (currentPoint < 0 || currentPoint >= points.Length) return;
        transform.position = Vector3.MoveTowards(transform.position, points[currentPoint], speed);
        if (Vector3.Distance(transform.position, points[currentPoint]) < 0.01f)
        {
            if (forward)
            {
                if (currentPoint == points.Length - 1)
                {
                    forward = false;
                    currentPoint--;
                }
                else
                {
                    currentPoint++;
                }
            }
            else
            {
                if (currentPoint == 0)
                {
                    forward = true;
                    currentPoint++;
                }
                else
                {
                    currentPoint--;
                }
            }
        }
    }
}