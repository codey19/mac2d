using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public GameObject soldier;
    public GameOverScreen gameOverScreen;

     void Update()
    {
        isWin();
    }

    public void isWin()
    {
        if (soldier.transform.position.x < -5.7f)
        {
            gameOverScreen.Setup();
            if(Input.GetKey(KeyCode.Q))
                Application.Quit();
        }
    }
}
