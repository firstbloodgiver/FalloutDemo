using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManController : MonoBehaviour {
	public float waittime;//尖叫间隔时间
    public float LookRange;//man的视野，进入开始尖叫
    
	public GameObject CollObjet;//死亡效果
	public GameObject Player;
	private bool audiocooldown=true;
	private AudioSource audioSource;

	
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
        if (audiocooldown == true){
			PlayAudio();
		}
		
		
	} 
    private void PlayAudio(){
		float dist;	
		dist =  Vector3.Distance(Player.transform.position,transform.position);
		audioSource.volume = LookRange/dist *0.5f;   //近大远小
		if(dist<LookRange){
			
			audiocooldown = false;
			audioSource.Play();
		    StartCoroutine(wait(waittime));
			}

	}

	IEnumerator wait(float waittime){
       yield return new WaitForSeconds(waittime);
	   audiocooldown = true;
	}


	private void OnTriggerEnter(Collider other){
			Instantiate(CollObjet,transform.position,transform.rotation);
			Destroy(this.gameObject);
	}
	
}
