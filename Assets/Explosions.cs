using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosions : MonoBehaviour
{
	public GameObject Explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnTriggerEnter2D(Collider2D other)
	{
		
		Destroy(other.gameObject);
		for(int i=1; i < 10; i++) {
		Explosion = Instantiate(Explosion, other.transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
		}
		}
	}
