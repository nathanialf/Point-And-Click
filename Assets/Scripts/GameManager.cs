using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Node currentNode;
    public static GameManager ins;
    GameObject player;
    GameObject[] interactables;

    void Awake()
    {
        ins = this;
        player = GameObject.FindWithTag("Player");
        interactables = GameObject.FindGameObjectsWithTag("Interactable");
    }

    void Update()
    {
        
    }
}
