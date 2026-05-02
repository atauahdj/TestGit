using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmoSphere : MonoBehaviour
{
    void OnTriggerStay(Collider cosmoZone)
    {
        cosmoZone.gameObject.GetComponent<Rigidbody>().useGravity = false;
    }
    void OnTriggerExit(Collider cosmoZone)
    {
        cosmoZone.gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
}
