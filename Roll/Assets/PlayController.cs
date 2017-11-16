using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour {
   // private Rigidbody rb;

	
	public float Speed;
	public float RSpeed;
	public float JumpSpeed;
	public float AudioSpeed;//最小撞击音频速度；
	public float ShiftSpeed;
	public float ShiftTime;

	public float shiftcooldown;

	public AudioClip JumpAudio;

	public AudioClip SpeedUpAudio;

	private AudioSource audiosource;
	private Rigidbody RB;

	private bool IsJump=true;

	private bool IsShift=true;
	

	
	void Start(){
		RB = GetComponent<Rigidbody>();
		audiosource = GetComponent<AudioSource>();
	}
	// Update is called once per frame
	void FixedUpdate () {
		
		
		float vert = Input.GetAxis("Vertical");
        float hori = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Speed * Time.deltaTime * vert);
        transform.Rotate(Vector3.up * RSpeed * Time.deltaTime * hori);
		
		if(Input.GetButtonDown("Jump")){
			Jump();		
		}

		if(Input.GetButtonDown("Shift")){
			Shift();
			Debug.Log("Shift");
					
		}
	}
	private void Shift(){
			if(IsShift == true){
				 IsShift = false;
                 Speed+=ShiftSpeed;
				 audiosource.clip = SpeedUpAudio;
					audiosource.Play();
				 StartCoroutine(Shifting(ShiftTime));
				 StartCoroutine(Shiftcooldown(shiftcooldown));
			}
			
	}
	

	private void Jump(){
			if(IsJump == true){
					IsJump = false;
					RB.AddForce(Vector3.up * JumpSpeed);
					audiosource.clip = JumpAudio;
		            audiosource.Play();
					
					
			}
	}

	private void OnCollisionEnter(Collision collision){
		IsJump = true;
		if(collision.relativeVelocity.sqrMagnitude > AudioSpeed){
				audiosource.clip = JumpAudio;
				audiosource.Play();
		}
		
	}
	IEnumerator Shifting(float ShiftTime){	
		yield return new WaitForSeconds(ShiftTime);		
		Speed-=ShiftSpeed;		
	}
	IEnumerator Shiftcooldown(float shiftcooldown){	
		yield return new WaitForSeconds(shiftcooldown);		
					
					IsShift = true;
					
					
	}




	
	
}
