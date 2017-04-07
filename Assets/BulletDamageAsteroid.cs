using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamageAsteroid : MonoBehaviour {



	void OnCollisionEnter2D(Collision2D coll){

		if(coll.gameObject.tag == "asteroid" )
			Destroy(coll.gameObject);

		Destroy(gameObject);
	

	}
}
