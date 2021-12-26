using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GO_build : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit2D hit = Physics2D.GetRayIntersection (ray, Mathf.Infinity);

			if (hit.collider.tag == "sh") {

				SceneManager.LoadScene ("SUNG");
			}
			if (hit.collider.tag == "sj") {

				SceneManager.LoadScene ("SONG");
			}
			if (hit.collider.tag == "jh") {

				SceneManager.LoadScene ("JONG");
			}
			if (hit.collider.tag == "sa") {

				SceneManager.LoadScene ("SAN");
			}
			if (hit.collider.tag == "wc") {

				SceneManager.LoadScene ("WON");
			}
			if (hit.collider.tag == "dg") {

				SceneManager.LoadScene ("DONG");
			}
			if (hit.collider.tag == "sg") {

				SceneManager.LoadScene ("SEO");
			}
			if (hit.collider.tag == "pd") {

				SceneManager.LoadScene ("PAL");
			}
			if (hit.collider.tag == "yk") {

				SceneManager.LoadScene ("YUL");
			}
			if (hit.collider.tag == "ds") {

				SceneManager.LoadScene ("DA");
			}

		}
	}
}
