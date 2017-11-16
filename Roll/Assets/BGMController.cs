using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMController : MonoBehaviour {
	public AudioSource Audiosource;

	public int wait;
	// Use this for initialization
	void Start () {
		Audiosource = GetComponent<AudioSource>();
		StartCoroutine(PlayBGM(wait));
	}
	
	// Update is called once per frame
	IEnumerator   PlayBGM(int wait){
		yield return new WaitForSeconds(wait);
       Audiosource.Play();
	}
}
