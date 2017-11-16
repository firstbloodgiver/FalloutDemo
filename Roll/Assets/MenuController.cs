using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
	public GameObject menu;

	public int GameLevel;

	private bool active=false;
	// Use this for initialization
	void Start () {
		menu.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			if(active == false){
					menu.SetActive(true);
					active = true;
			}
			else {
				menu.SetActive(false);
				active = false;
			}
			
		}
	}
	public void ClickRestar(){
		switch(GameLevel){
			case 1:SceneManager.LoadScene("Level1");break;
			case 2:SceneManager.LoadScene("Level2");break;
			case 3:SceneManager.LoadScene("Level3");break;
		}
		
	}

	public void ClickExit(){
			SceneManager.LoadScene("main");
	}
}
