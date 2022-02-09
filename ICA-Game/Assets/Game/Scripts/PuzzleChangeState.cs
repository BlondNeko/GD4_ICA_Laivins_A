using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class PuzzleChangeState : MonoBehaviour
{
    //following https://www.youtube.com/watch?v=cLzG1HDcM4s

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

    public void DestroyItem()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Enter");
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Player Enter");
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        Debug.Log("Exit");
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("Player Exit");
        }
    }
}
