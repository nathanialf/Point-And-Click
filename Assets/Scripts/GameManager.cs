using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Node currentNode;
    public static GameManager ins;

    void Awake()
    {
        ins = this;
    }
}
