using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public bool jumpCommand;
    Vector2 initialPosition, finalPosition;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                initialPosition = Input.GetTouch(0).position;
            }
            else if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                finalPosition = Input.GetTouch(0).position;
            }
        }
        if (finalPosition.y > initialPosition.y + 50)
        {
            jumpCommand = true;
        }
	}
}
