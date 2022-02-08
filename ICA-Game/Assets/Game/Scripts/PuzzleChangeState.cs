using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class PuzzleChangeState : MonoBehaviour
{
    public bool isInRange = false;
    public KeyCode interactKey;
    public UnityEvent interactAction;



    void Start()
    {

    }

    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Enter");
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("Exit");
        }
    }
}
