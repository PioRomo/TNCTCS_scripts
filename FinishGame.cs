using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class FinishGame : MonoBehaviour
{
    public void finished() {
        SceneManager.LoadScene(0);
    }

    public void freeRace() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }
}
