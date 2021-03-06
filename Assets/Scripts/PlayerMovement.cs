﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// This line will make sure one player doesn't have more than one ClickToMove script
[DisallowMultipleComponent]

public class PlayerMovement : MonoBehaviour
{
    // This variable will hold the 3d position of where we are going.
    private Vector3 target_position;

    // The NavMeshAgent will do all the magic when we get there.
    UnityEngine.AI.NavMeshAgent mesh_agent;
    Animator animator;
    Vector3 zero_speed;
    void Awake()
    {
        mesh_agent = GetComponent<NavMeshAgent>();
        animator = GameObject.Find("Player Sprite").GetComponent<Animator>();
        zero_speed = new Vector3(0, 0, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        // Set the default position of our target to the player.
        target_position = transform.position;
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
                mesh_agent.destination = hit.point;
            }
        }
        if (mesh_agent.velocity == zero_speed)
        {
            animator.SetInteger("WalkState", 0);
        }
        else
        {
            if (animator.GetInteger("WalkState") != 1)
            {
                animator.SetInteger("WalkState", 1);
            }
        }
    }

    void OnTriggerEnter(Collider collider)
    {
    }

    void OnTriggerStay(Collider collider)
    {
        GameObject collided_object = collider.gameObject;
        Node collided_node = collided_object.GetComponent<Node>();
        if (collided_node.interacted)
        {
            collided_node.Interact();
            collided_node.interacted = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
    }
}
