using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
	public Rigidbody rb;
	public GameObject prefab;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();



	}
	
	// Update is called once per frame
	void Update () {





			Ray beam = Camera.main.ScreenPointToRay (Input.mousePosition);



			Debug.DrawRay (beam.origin, beam.direction * 1000f);

			RaycastHit beamHit = new RaycastHit ();
		


		if (Physics.Raycast (beam, out beamHit, 1000f)) {

		



			Debug.Log ("You hit something bro");




			if (Input.GetMouseButtonDown (1)) {
			
				//Instantiate (prefab, beamHit.point, Quaternion.identity);
			
			
			
			}


			if (Input.GetMouseButtonDown (0)) {
				//beamHit.rigidbody.AddForce (Random.insideUnitSphere * 5000f);




				Debug.Log ("its working");


			}


		}
		}
}
