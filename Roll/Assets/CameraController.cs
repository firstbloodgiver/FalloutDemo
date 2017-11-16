using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
   
	public Transform traget;
    public Transform cameraChild;
    public float rotateSpeed;
    public float scaleSpeed;
    
    private Vector3 currentRotation;
    private Vector3 lastMousePosition;
    
	
	
	private void Start(){
        
        currentRotation = transform.eulerAngles;
        lastMousePosition = Input.mousePosition;
    }

    private void Update()
    {
         Vector3 mouseDelta = Input.mousePosition - lastMousePosition;
         lastMousePosition = Input.mousePosition;

         if(Input.GetMouseButton(1)){
             currentRotation.x += -mouseDelta.y * rotateSpeed * Time.deltaTime;
             currentRotation.y +=mouseDelta.x * rotateSpeed * Time.deltaTime;
         }
             
         
	     
        
         transform.position = traget.position;
         transform.eulerAngles = currentRotation;
         
        
    }
}
