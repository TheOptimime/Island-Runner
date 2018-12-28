using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]

public class Player : MonoBehaviour
{
    public float speed;
    public float verticalVelocity;
    public float jumpVelocity;
    public float gravity;
    InputManager inputM;
    
    public float foodMeter;
    bool doubleJumpUsed;

    CharacterController cc;

	// Use this for initialization
	void Start ()
    {
        foodMeter = 100f;
        cc = GetComponent<CharacterController>();
        inputM = FindObjectOfType<InputManager>();
	}
	
	// Update is called once per frame
	void Update ()
    {

        //Setting up move position
        Vector3 movePosition = Vector3.zero;
        movePosition.x = speed;
        verticalVelocity -= gravity;
        foodMeter-=0.01f;
        //Resets the double jump
        if (cc.isGrounded)
        {
            doubleJumpUsed = false;
        }

        //if statement for jump momentum and double jump
        if (inputM.jumpCommand && cc.isGrounded)
        {
            verticalVelocity = jumpVelocity;
        }
        else if (inputM.jumpCommand && !cc.isGrounded && !doubleJumpUsed)
        {
            verticalVelocity = jumpVelocity;
            doubleJumpUsed = true;

        }

        movePosition.y = verticalVelocity;

        
        if (cc.isGrounded==true && verticalVelocity < 0)
        {
            verticalVelocity = 0;
        }

        //Movement
        cc.Move(movePosition * Time.deltaTime);

        //Player starving to death
        if (foodMeter <= 0)
        {
            //kill all living things
        }
    }
}
