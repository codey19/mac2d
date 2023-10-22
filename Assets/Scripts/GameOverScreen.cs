using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    public void Setup() { 
        gameObject.SetActive(true);
        Debug.Log("hello1");
    }

    public void Restart() {
        gameObject.SetActive(!gameObject.activeSelf);
        Debug.Log("hello");

    }
}
