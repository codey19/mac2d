using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // This is so that it should find the Text component
using UnityEngine.Events; // This is so that you can extend the pointer handlers
using UnityEngine.EventSystems; // This is so that you can extend the pointer handlers

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Text>().text.Equals("Red Light")) {
            GetComponent<Text>().color = Color.red;
        }
        else {
            GetComponent<Text>().color = Color.green;
        }

    }
}
