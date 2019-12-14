using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D rb;
	float rand;
	
	public float WorldWidth = 10.0f;
	public float WorldHeight = 10.0f;
    // Start is called before the first frame update
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
		
    }

    // Update is called once per frame
    void Update()
    {
            if (transform.position.x > WorldWidth) {
			transform.position = new Vector3(WorldWidth, transform.position.y, 0);
		} else if (transform.position.x < -WorldWidth) {
			transform.position = new Vector3(-WorldWidth, transform.position.y, 0);
		}
		
		if (transform.position.y > WorldHeight) {
			transform.position = new Vector3(transform.position.x, WorldHeight, 0);
		} else if (transform.position.y < -WorldWidth) {
			transform.position = new Vector3(transform.position.x, -WorldHeight, 0);
        }
    }
}
