using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OozingMovement : MonoBehaviour
{
	Rigidbody2D rb;
	float rand;
    float forceAmount;
	
	public float WorldWidth = 60.0f;
	public float WorldHeight = 60.0f;
	
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
		
		rand = Random.Range(-1.0f, 1.0f);
        forceAmount = Random.Range(-1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
		if (forceAmount > 0) {
            rb.AddForce(transform.up * 3);
            if (rand < 0) {
                rb.AddTorque(-0.9f);
                rand += 0.01f;
                forceAmount = Random.Range(-1.0f, 1.0f);
                if (rand > 0) {
                    rand = Random.Range(0.5f, 1.0f);
                    forceAmount = Random.Range(-1.0f, 1.0f);
                }
            } else {
                rb.AddTorque(0.9f);
                rand -= 0.01f;
                if (rand < 0) {
                    rand = Random.Range(-1.0f, -0.5f);
                }
            }
        } else {
            rb.AddForce(transform.up * 5);
            forceAmount = Random.Range(-1.0f, 1.0f);
        }
		
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
