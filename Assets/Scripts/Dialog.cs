using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    Text dialog;
    int time_to_live;

    // Start is called before the first frame update
    void Start()
    {
        time_to_live = 0;
        dialog = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (time_to_live > 0)
        {
            //Debug.Log(time_to_live);
            time_to_live--;
        }
        else
        {
            dialog.gameObject.SetActive(false);
        }
    }

    public void ShowText(string text, int ttl)
    {
        dialog.text = text;
        dialog.gameObject.SetActive(true);
        //start the timer to show the text
        //time_to_live is number of frames
        time_to_live = ttl;
    }
}
