using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerBall: MonoBehaviour {

    //public GameObject Canvas_Start;
    public GameObject Canvas_Quit;
    int i = 0;

	void OnTriggerEnter(Collider other) {
		//Destroy(other.gameObject);

		if (other.gameObject.tag == "GameScore") {
			//Destroy (other.gameObject);
			gameObject.GetComponent <Renderer> ().material.color = Color.black;

		}

		if (other.gameObject.tag == "GameScore1") {
			//Destroy (other.gameObject);
			gameObject.GetComponent <Renderer> ().material.color = Color.blue;

		}

		if (other.gameObject.tag == "GameBomb") {
			Destroy (gameObject);

			//Canvas_Start.SetActive (true);
			//Canvas_Quit.SetActive (false);

			//Application.Quit ();
			
            

			if(i<3){
                
				i++;
				SceneManager.LoadScene (i);
				
			}
			//if(i==3){
			//	i=0;
			//	SceneManager.LoadScene (i);

           // }
				


		}

        if (other.gameObject.tag == "GameOver")
        {
            //Destroy (other.gameObject);
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
            Canvas_Quit.SetActive(true);
        }
    }

	// Use this for initialization
	void Start () {
		i = SceneManager.GetActiveScene().buildIndex;//获取当前场景编号
        Canvas_Quit.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.I)) {
			this.transform.Translate (0, 0, 10 * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.K)) {
			this.transform.Translate (0, 0, -10 * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.J)) {
			this.transform.Translate (-10 * Time.deltaTime, 0, 0);
		}

		if (Input.GetKey (KeyCode.L)) {
			this.transform.Translate (10 * Time.deltaTime, 0, 0);
		}
	}
}
