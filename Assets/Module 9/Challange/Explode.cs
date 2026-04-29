using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    private bool isGrounded = false;
    private bool sts =true;
    public float X;
    public float Z;
    public float Y;
    private void Update()
    {
        Debug.Log("boll isGrounded: " + isGrounded);
        Debug.Log("boll sts: " + sts);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Terrain"))
        {
            isGrounded = true;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            if(isGrounded && sts == true)
            {
                X = Random.Range(-10f, 10f);
                Z = X;   
                Y = 10f;
            }
            other.gameObject.GetComponent<Rigidbody>().AddForce(X, Y, Z, ForceMode.Impulse);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            sts = false;
        }
    }
}