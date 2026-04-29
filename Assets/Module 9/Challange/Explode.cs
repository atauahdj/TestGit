using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public KeyCode KeyInput;
    private bool isGrounded = false;
    public float X;
    public float Z;
    private void Start()
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyInput))
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
        Debug.Log(isGrounded);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Terrain"))
        {
            isGrounded = true;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            X = Random.Range(-10f, 10f);
            Z = X;
            if (isGrounded)
            {
                other.gameObject.GetComponent<Rigidbody>().AddForce(X, 30f, Z, ForceMode.Impulse);
                isGrounded = false;
            }
        }
    }
}