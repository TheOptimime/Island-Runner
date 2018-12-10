using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]

public class Player : MonoBehaviour
{
    public float speed;
    public float verticalVelocity;

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
        movePosition.y -= 9.8f;
        cc.Move(movePosition * Time.deltaTime);


	}
}
