using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmoSphere : MonoBehaviour
{
    void OnTriggerStay(Collider cosmoZone)
    {
        if(cosmoZone.gameObject != null)
        {
            cosmoZone.gameObject.GetComponent<Rigidbody>().useGravity = false;
        }
        else
        {
            Debug.Log("Зона пустая");
        }
    }
    void OnTriggerExit(Collider cosmoZone)
    {
        if(cosmoZone.gameObject != null)
        {
           cosmoZone.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }

}
