using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OozingSpawn : MonoBehaviour
{
	float cloneTimer;
	float childTimer;
	
	public GameObject Clone;
	public GameObject Child;
	
	public float ChildIntervalMin = 15.0f;
	public float ChildIntervalMax = 25.0f;
	
	public float CloneIntervalMin = 90.0f;
	public float CloneIntervalMax = 120.0f;
	
    // Start is called before the first frame update
    void Start()
    {
        cloneTimer = Random.Range(CloneIntervalMin, CloneIntervalMax);
		childTimer = Random.Range(ChildIntervalMin, ChildIntervalMax);
    }

    // Update is called once per frame
    void Update()
    {
		childTimer -= Time.deltaTime;
		if (childTimer < 0 && Child != null) {
			childTimer = Random.Range(ChildIntervalMin, ChildIntervalMax);
			Instantiate(Child, transform.position, transform.rotation);
		}
		
		cloneTimer -= Time.deltaTime;
		if (cloneTimer < 0 && Clone != null) {
			cloneTimer = Random.Range(CloneIntervalMin, CloneIntervalMax);
			Instantiate(Clone, transform.position, transform.rotation);
		}     
    }
}
