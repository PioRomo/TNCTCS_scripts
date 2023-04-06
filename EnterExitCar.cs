using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterExitCar : MonoBehaviour
{
    public MonoBehaviour CarController;
    public MonoBehaviour CatController;

    public Transform car;
    public Transform Player;

    //public GameObject DriveUI;
    //public GameObject playerCam;
    //public GameObject carCam; 

    public bool canDrive;

    // Start is called before the first frame update
    void Start()
    {
        CarController.enabled = true;
        //DriveUI.gameObject.SetActive(false);
        //canDrive = true; 

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E)) {
            CarController.enabled = false;
            CatController.enabled = true; 

            //DriveUI.gameObject.SetActive(false);
            //Player.transform.SetParent(car);
            car.gameObject.SetActive(false);

            Player.gameObject.SetActive(true);

            canDrive = false; 


            //playerCam.gameObject.SetActive(false);
            //carCam.gameObject.SetActive(true);


        }

   
    }
}
