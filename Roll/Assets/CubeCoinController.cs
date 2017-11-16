using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCoinController : MonoBehaviour {
	public Vector3 rot;
	public CoinNum coinNum;
	public GameObject CollObjet;
	
	
	
	
	
	
	void Update () {
		transform.Rotate(rot);
	}

	private void OnTriggerEnter(Collider other){
		coinNum.CountNumber++;
		Instantiate(CollObjet,transform.position,transform.rotation);	
		Destroy(this.gameObject);
				
	}
	
}
