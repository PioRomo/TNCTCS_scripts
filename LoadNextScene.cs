using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    [SerializeField] private int sceneNumber;

    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.Debug.Log("Collision Detected.");
        //UnityEngine.Debug.Log(other.tag);
        if (other.tag == "Player") {
            UnityEngine.Debug.Log("Should be working."); 
            SceneManager.LoadScene(sceneNumber);
        }
        
        
    }

}
