using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieCubeCoin : MonoBehaviour {

	void Start () {
		StartCoroutine(wait(5));
	}

	IEnumerator wait(float i){
       yield return new WaitForSeconds(i);
	   Destroy(this.gameObject);
	}
}
