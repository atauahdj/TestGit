using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
             transform.rotation = Quaternion.Euler(90,0,-45);
        }
        if (Input.GetKey(KeyCode.D))
        {
             transform.rotation = Quaternion.Euler(90,0,-135);
        }
    }
}
