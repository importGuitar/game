using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBall: MonoBehaviour {

    protected float jump_speed = 5.0f;  //设置起跳时的速度

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))  //点击鼠标左键触发
        {
            this.GetComponent<Rigidbody>().velocity = Vector3.up * this.jump_speed;  //设定向上速度
        }
    }
}
