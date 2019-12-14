using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShroomMovement : MonoBehaviour

{
	Rigidbody2D rb;
	bool isGrounded = true;

	
	public int movespeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
		
    }
	
	void OnCollisionStay2D() {
	 
			Debug.Log("Möö");
		isGrounded=true; 

	}
	


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) 
		{
			if (isGrounded == true) {
			rb.AddForce(new Vector2(0,5), ForceMode2D.Impulse);
			isGrounded = false;
			}
		
		}	
		
		if(Input.GetKey(KeyCode.D)) {
			rb.AddForce(transform.right * movespeed);
			
		}
		if(Input.GetKey(KeyCode.A)) {
			rb.AddForce(transform.right * -movespeed);
			
		}

	
		
	}		
	
}
