using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterTrack : MonoBehaviour
{

    public GameObject enterTrack;
    private GameObject car; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") {
            Time.timeScale = 0f;
            enterTrack.SetActive(true);
            car = collision.gameObject;
        }
    }

    public void YesTrack() {
        enterTrack.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    public void NoTrack() {
        enterTrack.SetActive(false); 
        Time.timeScale = 1f;
        car.transform.position = new Vector3(205, -1, 159);

    }
}
