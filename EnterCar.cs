using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterCar: MonoBehaviour
{
    private bool inCar = false;
    public CarController vehicleScript;
    
    //[SerializeField] GameObject car;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //vehicleScript = GetComponent<CarController>();
        player = GameObject.FindWithTag("Player");
        //car.SetActive(false); 
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && inCar == false) {
            //car.SetActive(true);
            if (Input.GetKey(KeyCode.E)) {
               // car.SetActive(false);
                player.transform.parent = gameObject.transform;
                vehicleScript.enabled = true;  
                player.SetActive(false);
                inCar = true; 
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player") {
           // car.SetActive(false); 
        }
    }

    private void Update()
    {
        if (inCar == true && Input.GetKey(KeyCode.E)) {
            vehicleScript.enabled = false;  
            player.SetActive(true);
            player.transform.parent = null;
            inCar = false; 
        }


    }
}
