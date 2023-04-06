using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class CatController : MonoBehaviour
{
    //for model switches
    [SerializeField] private GameObject model1;
    //[SerializeField] private GameObject model2;
   
    

    //declare reference variables
    private PlayerControls playerControls;
    private CharacterController characterController;
    private Animator anim;
    private int isWalkingHash;
    private int isSittingHash;

    private int isGhoulRunningHash;
    private int isGhoulWalkingHash;

    private Transform cameraMainTransform; 

    //variables to store input values
    private Vector2 currentMovementInput;
    private Vector3 currentMovement;
    private bool isMovementPressed;
    private bool isSitPressed;
    private bool isRunPressed; 
    [SerializeField] private float rotationFactorPerFrame = 1.0f;
    [SerializeField] private float movementSpeed = 1.0f; 

    // Awake is called even earlier than start 
    void Awake()
    {
    
        //model2.SetActive(false);
        model1.SetActive(true);
        

        playerControls = new PlayerControls();
        characterController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();

        isWalkingHash = Animator.StringToHash("isWalking");
        isSittingHash = Animator.StringToHash("isSitting");
        //isGhoulWalkingHash = Animator.StringToHash("isGhoulWalking");
        //isGhoulRunningHash = Animator.StringToHash("isGhoulRunning"); 

        //for walking
        playerControls.CatControls.Walk.started += OnMovementInput;
        playerControls.CatControls.Walk.canceled += OnMovementInput;
        playerControls.CatControls.Walk.performed += OnMovementInput;

        //for sitting
        playerControls.CatControls.Sit.started += OnSit;
        playerControls.CatControls.Sit.canceled += OnSit;

        //for running
        playerControls.CatControls.Run.started += OnRun;
        playerControls.CatControls.Run.canceled += OnRun;

        cameraMainTransform = Camera.main.transform; 


    }


    void handleGravity()
    {
        float gravityConstant;
        if (characterController.isGrounded)
        {
            gravityConstant = -.05f;
            currentMovement.y = gravityConstant;
        }
        else {
            gravityConstant = -9.8f;
            currentMovement.y += gravityConstant; 
        }
    }

    void handleRotation()
    {
        Vector3 positionToLookAt;
        positionToLookAt.x = currentMovement.x;
        positionToLookAt.y = 0.0f;
        positionToLookAt.z = currentMovement.z;
         
        Quaternion currentRotation = transform.rotation;

        if (isMovementPressed) {
            Quaternion targetRotation = Quaternion.LookRotation(positionToLookAt);
            transform.rotation = Quaternion.Slerp(currentRotation, targetRotation, rotationFactorPerFrame * Time.deltaTime);

        }

    }

    void OnMovementInput(InputAction.CallbackContext context)
    {
        /*currentMovementInput = context.ReadValue<Vector2>();
        currentMovement.x = currentMovementInput.x;
        currentMovement.z = currentMovementInput.y;
        isMovementPressed = currentMovementInput.x != 0 || currentMovementInput.y != 0;*/

        //get player input values
        currentMovementInput = context.ReadValue<Vector2>();

        //get camera-normalized directional vectors
        Vector3 forward = cameraMainTransform.forward;
        Vector3 right = cameraMainTransform.right;
        forward.y = 0;
        right.y = 0;
        forward = forward.normalized;
        right = right.normalized;

        //create direction-relative input vectors
        Vector3 forwardRelativeVerticalInput = currentMovementInput.y * forward;
        Vector3 rightRelativeVerticalInput = currentMovementInput.x * right;

        //create camera-relative movement
        Vector3 cameraRelativeMovement = forwardRelativeVerticalInput + rightRelativeVerticalInput;

        //Apply relative movement to current movement direction.        
        currentMovement.x = cameraRelativeMovement.x;
        currentMovement.z = cameraRelativeMovement.z;
        isMovementPressed = currentMovementInput.x != 0 || currentMovementInput.y != 0;


    }

    void OnSit(InputAction.CallbackContext context)
    {
        isSitPressed = context.ReadValueAsButton(); 
    }

    void OnRun(InputAction.CallbackContext context)
    {
        isRunPressed = context.ReadValueAsButton();
    }

    void handleAnimation()
    {
        
            bool isWalking = anim.GetBool(isWalkingHash);
            bool isSitting = anim.GetBool(isSittingHash);


            if (isSitPressed && !isSitting)
            {
                anim.SetBool(isWalkingHash, false);
                anim.SetBool(isSittingHash, true);
            }
            else if (isMovementPressed && !isWalking)
            {
                anim.SetBool(isSittingHash, false);
                anim.SetBool(isWalkingHash, true);
            }
            else if (!isSitPressed && isSitting)
            {
                anim.SetBool(isSittingHash, false);
            }
            else if (!isMovementPressed && isWalking)
            {
                anim.SetBool(isWalkingHash, false);
            }
            else if (isMovementPressed && isSitPressed && ((isWalking || isSitting) || (isWalking && isSitting)))
            {
                anim.SetBool(isWalkingHash, false);
                anim.SetBool(isSittingHash, true);
            }
        
    }

    void OnEnable()
    {
        playerControls.CatControls.Enable();  
    }

    void OnDisable()
    {
        playerControls.CatControls.Disable();   
    }

    // Update is called once per frame
    void Update()
    {
       
        handleGravity(); 
        handleRotation();
        handleAnimation();
        //modelSwitch(); 

        
        //handle possible sitting bugs for the cat
        if (!isSitPressed)
        {
            
            characterController.Move(currentMovement * Time.deltaTime * movementSpeed);
            
        }
        else {
            
            characterController.Move(currentMovement * Time.deltaTime);
         }

        
    }

   
}

 