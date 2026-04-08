using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private GameObject firstObject;
    [SerializeField] private GameObject secondObject;

    private GameObject currentObject;

    private void Start()
    {
        firstObject.SetActive(true);
        currentObject = firstObject;
    }

    public void ChangeState(GameObject state)
    {
        if (currentObject != null)
        {
            currentObject.SetActive(false);
            state.SetActive(true);
            currentObject = state;

        }
    }

}
