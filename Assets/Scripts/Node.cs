using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public string inspect_text;

    [HideInInspector]
    public Collider col;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider>();
    }

    void OnMouseDown()
    {
        PickUp();
    }

    void PickUp()
    {
        if(inspect_text != null)
            Debug.Log(inspect_text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
