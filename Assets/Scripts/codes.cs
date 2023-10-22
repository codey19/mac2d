using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.WebSockets;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class codes : MonoBehaviour
{
    Vector3 center;
    float timePeriod;
    bool isRed;
    public Text display;
    public GameObject soldierPrefab;
    public GameOverScreen gameOverScreen;
    Vector3 start;
    Vector2 origin;
    bool isKill;

    // Start is called before the first frame update
    void Start()
    {
        origin = soldierPrefab.transform.position;
        start = origin;
        isRed = true;
        isKill = false;
        ///center = new Vector3(transform.position.x, transform.position.y - transform.localScale.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (isKill) {
            if (Input.GetKey(KeyCode.Space))
            {
                Debug.Log("hello2");
                isKill = false;
                gameOverScreen.Restart();
            }
            return;
        }
            
        float timeRed = 3;//in seconds
        float timeGreen = 7;//in seconds
        timePeriod += Time.deltaTime;
        //System.Console.WriteLine(timePeriod);
        if (isRed)
        {
            
            if (timePeriod > timeRed)
            {
                transform.localScale = new Vector3(-3, 3, 3);
                //transform.Rotate(center, 180f);
                // System.Console.WriteLine("mark");
                timePeriod = 0;
                isRed = false;
                Debug.Log("on");
            }
        }
        if (!isRed)
        {
            start = soldierPrefab.transform.position;
            if (timePeriod > timeGreen)
            {
                transform.localScale = new Vector3(3, 3, 3);
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
            display.text = "Red Light";
            if (timePeriod > 1)
                kill();
            else
                start = soldierPrefab.transform.position;
        }
        else
        {
            display.text = "Green Light";

        }
    }

    void kill() {
        if (soldierPrefab.transform.position.x < 8.3 && soldierPrefab.transform.position.x != start.x)
        {
            soldierPrefab.transform.position = origin;
            gameOverScreen.Setup();
            isKill = true;
           
            Debug.Log("kill");
        }
    }
}
