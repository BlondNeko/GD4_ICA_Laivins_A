using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Camera camera;

    public NavMeshAgent agent;

    public Animator anim;

    //public GameObject destination;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //destination.transform.position = hit.point;
                agent.SetDestination(hit.point);
            }
        }

        if (agent.velocity != Vector3.zero)
        {
            anim.SetBool("isWalk", true);
        }
        else if (agent.velocity == Vector3.zero)
        {
            anim.SetBool("isWalk", false);
        }
    }
}
