using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Superman : MonoBehaviour
{
    [Header("Superman Setting")]
    public float TimeLaser;
    float currentTime;
    public GameObject laserEyes;
    public float strong = 1f;
    public float speedSuper = 1f;
    //private Rigidbody rb;
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(currentTime >= TimeLaser)
        {
            currentTime -= Time.deltaTime;
            laserEyes.SetActive(true);
        }
        else
        {
            laserEyes.SetActive(false);
        }
        gameObject.GetComponent<Rigidbody>().AddForce(speedSuper,0f,0f, ForceMode.Force);
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("BadGuy") & (collider.gameObject.GetComponent<Rigidbody>() != null))
        {
            collider.gameObject.GetComponent<Rigidbody>().AddForce(0f, 0f, strong, ForceMode.Impulse);
            Debug.Log("Rigidbody есть и BadGuy уничтожен");
            currentTime = TimeLaser;
        }
        else if (collider.gameObject.CompareTag("GoodBoy") & (collider.gameObject.GetComponent<Rigidbody>() != null))
        {
            collider.gameObject.GetComponent<BoxCollider>().enabled = false;
            collider.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            Debug.Log("Это хороший парень, его не трогаем");
        }
        else
        {
            Debug.Log("Rigidbody отсутствует");
        }
    }
}
