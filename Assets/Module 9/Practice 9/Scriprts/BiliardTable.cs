using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BiliardTable : MonoBehaviour
{
    public float StrongHit;
    public TMP_Text QB;
    static int quantityBalls;
    bool Hit = true;
    public bool itsBall = false;
    public  bool itsTrig = false;
    void Update()
    {
        if (itsBall)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (Hit)
                {
                    gameObject.GetComponent<Rigidbody>().AddForce(StrongHit,0,0, ForceMode.Impulse);
                    Hit = false;
                    Debug.Log(Hit);
                }
            }
        }
    }
    void OnTriggerEnter(Collider loonk)
    {
        if (itsTrig)
        {
            if (loonk.gameObject.CompareTag("Ball"))
            {
                quantityBalls = quantityBalls + 1;
                QB.text = $"забито {quantityBalls}/15";
                Debug.Log(quantityBalls);
            }
        }
    }
}
