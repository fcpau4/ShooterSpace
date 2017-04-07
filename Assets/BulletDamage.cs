using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour {

	public GameObject heart;
	public GameObject heart2;
	public GameObject heart3;

	public int counter=3;
	
	void OnCollisionEnter2D(Collision2D coll){

		if(coll.gameObject.tag == "ship"){
			
			counter--;
			Destroy(coll.gameObject);
			
		}
		Destroy(gameObject);
		
	}

}
