using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPTriggerScript : MonoBehaviour
{
    public Transform TP;
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.position = TP.position;
        }
    }
}
