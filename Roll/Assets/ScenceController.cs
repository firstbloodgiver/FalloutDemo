using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScenceController : MonoBehaviour {
	public Image image;
	// Use this for initialization
	void Start () {
		image.CrossFadeAlpha(1, 0f, true);
		StartCoroutine(Wait1(2));
	}
	
	IEnumerator Wait1(int waitfor)
    {
        yield return new WaitForSeconds(waitfor);
        image.CrossFadeAlpha(0, 1f, true);
        
    }
}
