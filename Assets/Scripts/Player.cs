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

    CharacterController cc;

	// Use this for initialization
	void Start ()
    {
        cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Setting up move position
        Vector3 movePosition = Vector3.zero;
        movePosition.x = speed;
        verticalVelocity -= gravity;
        

        //if statement for jump momentum
        if (Input.GetButtonDown("Jump") && cc.isGrounded)
        {
            verticalVelocity = jumpVelocity;
        }

        movePosition.y = verticalVelocity;

        //Prevents infinite falling
        if (cc.isGrounded==true && verticalVelocity < 0)
        {
            verticalVelocity = 0;
        }

        //Movement
        cc.Move(movePosition * Time.deltaTime);

        
    }
}
