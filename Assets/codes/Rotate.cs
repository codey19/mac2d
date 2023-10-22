using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.WebSockets;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class NewBehaviourScript : MonoBehaviour
{
    Vector3 center;
    float timePeriod;
    bool isRed;
    public Text display;
    public GameObject soldier;
    Vector3 start;
    // Start is called before the first frame update
    void Start()
    {
        start = soldier.transform.position;
        isRed = true;
        center = new Vector3(transform.position.x, transform.position.y - transform.localScale.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        float timeRed = 3;//in seconds
        float timeGreen = 7;//in secondsd
        timePeriod += Time.deltaTime;
        //System.Console.WriteLine(timePeriod);
        if (isRed)
        {
            if (timePeriod > timeRed)
            {
                transform.Rotate(center, 180f);
                // System.Console.WriteLine("mark");
                timePeriod = 0;
                isRed = false;
                Debug.Log("on");
            }
        }
        if (!isRed)
        {
            start = soldier.transform.position;
            if (timePeriod > timeGreen)
            {
                transform.Rotate(center, 180f);
                // System.Console.WriteLine("mark");
                timePeriod = 0;
                isRed = true;
                Debug.Log("not on");
            }
        }
        chengeText();


        //if (Input.GetKeyDown(KeyCode.Space))

    }
    void chengeText()
    {
        if (isRed)
        {
            display.text = "RED LIGHT";
            if (!soldier.transform.position.Equals(start))
            {

            }
        }
        else
        {
            display.text = "GREEN LIGHT";

        }
    }
}
