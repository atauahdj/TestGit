using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class TirggerThrow : MonoBehaviour
{
    void Start()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "Podopotniy")
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(0,10,0, ForceMode.Impulse);
        }
    }
}
