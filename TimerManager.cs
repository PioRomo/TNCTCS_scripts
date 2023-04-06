using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; 

public class TimerManager : MonoBehaviour
{
    //Component
    public TextMeshProUGUI timerText;

    //Timer Settings
    public float currentTime;

    //Limit Settings
    public float timerLimit; 
    

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.isPaused)
        {
            currentTime -= Time.deltaTime;
        }

        if (CoinCounter.coinAmount >= 8)
        {
            UnityEngine.Debug.Log("coins are greater than 8");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (currentTime <= timerLimit) {
            currentTime = timerLimit;
            setTimerText(); 
            timerText.color = Color.red;
            enabled = false;
            Time.timeScale = 0f; 
   
        }
        setTimerText();
         
    }

    private void setTimerText() {
        if (currentTime <= 0)
        {
            timerText.text = "You Lose! Restart and try again!";
        }
        else {
            timerText.text = "Time Left: " + currentTime.ToString("0.00");
        }
        
    }
}
