using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VecGuide : MonoBehaviour
{
    public Transform targert;
    public float time;
    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, targert.position, time);
        transform.Rotate(0, 1, 0);
        //transform.LookAt(targert);
    }
    private void OnTriggerEnter(Collider col)
    {
        /*if(col.CompareTag("Player"))
        {
            Debug.Log("You Lose");
        }*/
    }
}
