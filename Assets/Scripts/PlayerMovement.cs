using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// This line will make sure one player doesn't have more than one ClickToMove script
[DisallowMultipleComponent]

public class PlayerMovement : MonoBehaviour
{
    // This variable will hold the 3d position of where we are going.
    private Vector3 targetPosition;

    // The NavMeshAgent will do all the magic when we get there.
    UnityEngine.AI.NavMeshAgent meshAgent;

    void Awake()
    {
        meshAgent = GetComponent<NavMeshAgent>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Set the default position of our target to the player.
        targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        MovePlayer();
    }

    void MovePlayer()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 50))
            {
                meshAgent.destination = hit.point;
            }
        }
    }
}
