using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SieniLifetime : MonoBehaviour
{
	public float Lifetime = 5.0f;
	
    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
        Lifetime -= Time.deltaTime;
		if (Lifetime < 0) {
			Destroy(this.gameObject);
		}
    }
}
