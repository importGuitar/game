using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundControl : MonoBehaviour {


    public AudioSource audio1;
    public Scrollbar Scontrol;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        audio1.volume = Scontrol.value;
	}
}
