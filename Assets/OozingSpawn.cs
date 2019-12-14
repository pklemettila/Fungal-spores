using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OozingSpawn : MonoBehaviour
{
	float cloneTimer;
	float childTimer;
	
	public GameObject Clone;
	public GameObject Child;
	
    // Start is called before the first frame update
    void Start()
    {
        cloneTimer = Random.Range(15.0f, 20.0f);
		childTimer = Random.Range(5.0f, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
		childTimer -= Time.deltaTime;
		if (childTimer < 0 && Child != null) {
			childTimer = Random.Range(5.0f, 10.0f);
			Instantiate(Child, transform.position, transform.rotation);
		}
		
		cloneTimer -= Time.deltaTime;
		if (cloneTimer < 0 && Clone != null) {
			cloneTimer = Random.Range(15.0f, 20.0f);
			Instantiate(Clone, transform.position, transform.rotation);
		}     
    }
}
