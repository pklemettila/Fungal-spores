using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
	Rigidbody2D rb;
	public GameObject ammussieni;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		
		if (Input.GetKeyDown("space")) {
        Vector3 spawnPos = rb.transform.position;
	    spawnPos.z = 0.0f; 
		spawnPos.x += 2f;
		
		GameObject sieniInstance = Instantiate(ammussieni, spawnPos, Quaternion.Euler(new Vector3(0, 0, 0)));
        
    }
}
}