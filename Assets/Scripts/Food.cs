using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public int foodValue;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        Player player = FindObjectOfType<Player>();
        player.foodMeter += foodValue;
        Destroy (this.gameObject);
    }
}
