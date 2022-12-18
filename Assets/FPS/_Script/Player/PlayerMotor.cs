using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{

    private CharacterController characterController;
    private Vector3 motorVelocity;
    public float speed = 5f;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;
    // Start is called before the first frame update
    void Start()
    { 
        characterController = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {

        


        //Speed Debugging
        Debug.Log(speed);

    }

    //Receive the inputs for our InputManager.cs and apply them to our character controller
    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        characterController.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        motorVelocity.y += gravity * Time.deltaTime;
        characterController.Move(motorVelocity * Time.deltaTime);


       

    }
    

  
   

}
