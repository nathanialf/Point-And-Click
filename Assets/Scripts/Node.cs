using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour
{
    public string flavor_text;
    Text dialog;

    [HideInInspector]
    public Collider col;
    public bool interacted = false;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider>();
        dialog = GameObject.Find("Dialog").GetComponent<Text>();
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
        dialog.text = flavor_text;
        Debug.Log(flavor_text);
    }
}
