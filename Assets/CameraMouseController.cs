using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouseController : MonoBehaviour {

	public Transform Camera;
	public float dstFromCharacter=2;
	

	public Vector2 x_value_MaxMin=new Vector2(-40,85);
	public Vector2 y_value_MaxMin=new Vector2(-40,85);

	float y_value;
	float x_value;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		y_value +=Input.GetAxis("Mouse X");
		x_value -=Input.GetAxis("Mouse Y");
		x_value=Mathf.Clamp(x_value,x_value_MaxMin.x,x_value_MaxMin.y);
		y_value=Mathf.Clamp(y_value,y_value_MaxMin.x,y_value_MaxMin.y);

		Vector3 cameraRoation =new Vector3(x_value,y_value);
		Camera.eulerAngles=cameraRoation;
		
		
		
		
	}
}
