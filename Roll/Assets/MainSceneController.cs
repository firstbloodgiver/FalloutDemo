using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainSceneController : MonoBehaviour {
	public Vector3 rot;
	public Image image;
	public Image comtronote;// 操作指南
	public int wait;
	public GameObject LightPoin;
	public AudioSource Audiosource;

	
	// Use this for initialization
	void Start () {
		Audiosource = GetComponent<AudioSource>();
		StartCoroutine(PlayBGM(wait));
		image.gameObject.SetActive(false);
		comtronote.gameObject.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		LightPoin.transform.Rotate(rot);
		

		
	}
	public void StarOnClick()
    {
        //载入
		image.gameObject.SetActive(true);

		image.CrossFadeAlpha(0, 0f, true);//淡入执行参数，1=显示 0.5f=时间 true=          
            StartCoroutine(Wait1(2));
        

    }

	IEnumerator Wait1(int waitfor)
    {
        yield return new WaitForSeconds(waitfor);
		image.CrossFadeAlpha(1, 2f, true);//淡入执行参数，1=显示 0.5f=时间 true=  
		for(float i = 1;i>=0;i=i-0.1f){
			Audiosource.volume = i; 
		}
		       
        SceneManager.LoadScene("Level2");
        
    }
	IEnumerator   PlayBGM(int wait){
		yield return new WaitForSeconds(wait);
       Audiosource.Play();
	}

	public void ExitOnClick()
    {
       
        Application.Quit();
    }
	public void OperatingOnClick()
    {
        comtronote.gameObject.SetActive(true);
        

    }
	public void OperatingCloseOnClick()
    {
        comtronote.gameObject.SetActive(false);
        

    }
	
}
