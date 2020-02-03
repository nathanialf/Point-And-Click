using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour
{
    public string flavor_text;

    [HideInInspector]
    public Collider col;
    public bool interacted = false;
    public Node ins;

    // Start is called before the first frame update
    void Start()
    {
        ins = this;
        col = GetComponent<Collider>();
    }

    void OnMouseDown()
    {
        PickUp();
    }

    void PickUp()
    {
        interacted = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Interact()
    {
        Debug.Log(flavor_text);
    }
}
