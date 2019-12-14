using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
	
	public float speed;
	Rigidbody2D ribo;
    // Start is called before the first frame update
    void Start()
    {
		
		ribo = GetComponent<Rigidbody2D> ();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void FixedUpdate() {
		
		float moveHorizontal = Input.GetAxis("Horizontal"); 
		
		float moveVertical = Input.GetAxis("Vertical");
		
		ribo.velocity = new Vector2(speed * moveHorizontal, speed * moveVertical);

		
	}
}
