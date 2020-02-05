using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour
{
    public string flavor_text;
    Text UI_dialog;

    [HideInInspector]
    public Collider col;
    public bool interacted = false;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider>();
        UI_dialog = GameObject.Find("Dialog").GetComponent<Text>();
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
        Dialog dialog_script = UI_dialog.GetComponent<Dialog>();
        dialog_script.ShowText(flavor_text, 200);
        Debug.Log(flavor_text);
    }
}
