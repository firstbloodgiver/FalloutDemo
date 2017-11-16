using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieManController : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
		StartCoroutine(wait(2));
	}
	IEnumerator wait(float i){
       yield return new WaitForSeconds(i);
	   Destroy(this.gameObject);
	}
	// Update is called once per frame
	
}
