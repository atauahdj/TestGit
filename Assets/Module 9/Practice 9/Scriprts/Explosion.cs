using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float StrongExplosion;
    public float maxTime;
    private float timeExplosion = 0f;
    private bool Boom = false;
    void OnTriggerStay(Collider other)
    {
        if(Boom)
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(0,StrongExplosion,0, ForceMode.Impulse);
        }
    }
    void Update()
    {
        if (!Boom)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                timeExplosion = maxTime;
                Boom = true;
                Debug.Log("Boom!");
            }
        }
        if (Boom)
        {
            timeExplosion -= Time.deltaTime;
        }
        if(timeExplosion <=0f)Boom = false;
    }
}
