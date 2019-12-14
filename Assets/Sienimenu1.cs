using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sienimenu1 : MonoBehaviour
{
	
    public GameObject menusieni1;
	public int mikasieni;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnMouseDown() {
		Debug.Log("Clicky");
		SieniSpawn.sieniValue = 1;
	}
}
