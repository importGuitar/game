using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startScript : MonoBehaviour {

    public GameObject Canvas_Start;
	// Use this for initialization
	void Start () {
        this.GetComponent<Button>().onClick.AddListener(delegate ()
        {
            Canvas_Start.SetActive(false);
        });
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
