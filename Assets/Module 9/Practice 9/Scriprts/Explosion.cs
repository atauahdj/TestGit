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
        if(timeExplosion > 0f)
        {
            if(other.gameObject == GetComponent<Rigidbody>())
            {
                 other.gameObject.GetComponent<Rigidbody>().AddForce(0,1f,0, ForceMode.Impulse);
            }
        }
    }
    void Update()
    {
        if (Boom)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                timeExplosion = maxTime;
                Boom = false;
            }
        }
        if(timeExplosion <= 0f)
        {
            Boom = true;
        }
        timeExplosion -= Time.deltaTime;
    }
}
