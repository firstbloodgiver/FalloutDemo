using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {
    private AudioSource audiosource;
	public float AudioSpeed;
	public AudioClip Audio;
	// Use this for initialization
	void Start () {
		audiosource = GetComponent<AudioSource>();
	}
	
	private void OnCollisionEnter(Collision collision){
		if(collision.relativeVelocity.sqrMagnitude > AudioSpeed){
				audiosource.clip = Audio;
				audiosource.Play();
		}
		
	}
}
