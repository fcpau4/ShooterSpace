using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlayer : MonoBehaviour {

	public GameObject bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	void Update(){

		if(Input.GetKeyDown(KeyCode.Space)){
			GameObject g = (GameObject) Instantiate(bullet,
				transform.position,
				Quaternion.identity);

			GameObject player = GameObject.Find("PlayerShip");
			if(!player){
			Physics2D.IgnoreCollision(g.GetComponent<Collider2D>(), 
				player.GetComponent<Collider2D>());
			}
					
		}

	}
}
