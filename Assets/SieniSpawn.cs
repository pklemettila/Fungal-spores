using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SieniSpawn : MonoBehaviour
{
	
	public GameObject sieni1, sieni2;
	public static int sieniValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown(0)) {
        Vector3 spawnPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	    spawnPos.z = 0.0f; 
    
	if (sieniValue == 1) {
	GameObject sieniInstance = Instantiate(sieni1, spawnPos, Quaternion.Euler(new Vector3(0, 0, 0)));
			} else if (sieniValue == 2) {
					GameObject sieniInstance = Instantiate(sieni2, spawnPos, Quaternion.Euler(new Vector3(0, 0, 0)));

			}
		}
	} 
	

}