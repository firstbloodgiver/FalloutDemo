using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ChangeScence : MonoBehaviour {
	public CoinNum coinNum;
	public Image image;
	// Use this for initialization
	void Start () {
		
	}
	
	private void OnTriggerEnter(Collider other){
		StartCoroutine(wait(3));
		image.CrossFadeAlpha(1, 3f, true);
				
	}

	IEnumerator wait(float i){
       yield return new WaitForSeconds(i);
	   
	   if(coinNum.CountNumber == 5){
			SceneManager.LoadScene("Level1");
			
		}
		SceneManager.LoadScene("Level3");
		


		if(coinNum.CountNumber == 10){
			SceneManager.LoadScene("main");
			
		}
	}
}
